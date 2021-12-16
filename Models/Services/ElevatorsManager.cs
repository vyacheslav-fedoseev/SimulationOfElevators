using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;
using Models.Entities;
using System.Threading;

namespace Models.Services
{
    public class ElevatorsManager : IElevatorsManager
    {
        private readonly IElevatorRepository _elevatorsRepository;
        private readonly IPeopleRepository _peopleRepository;
        private readonly IFloorRepository _floorRepository;
        private Thread _thread;
        private readonly ITimer _updateTimer;
        private readonly ITimer _timer;
        public object Locker = new object();
        private DateTime _simulationStart;
        //private DateTime[] _elevatorsMoveTime;
        public static float _time { get; private set; }
        private readonly bool[,] _elevatorsGrid;
        public event Action DataUpdated;

        public static bool IsFire { get; private set; }
        private float _simulationSpeed = 1;
        private const float _floorHeight = 2.5F;
        public ElevatorsManager(IElevatorRepository elevatorsRepository, IPeopleRepository peopleRepository, IFloorRepository floorRepository, ITimer timer, ITimer updateTimer)
        {
            _elevatorsRepository = elevatorsRepository;
            _peopleRepository = peopleRepository;
            _floorRepository = floorRepository;

            _updateTimer = updateTimer;
            _updateTimer.Interval = 100;
            _updateTimer.Tick += (sender, args) => Invoke(DataUpdated);

            IsFire = false;
            _timer = timer;
            _timer.Interval = 100;
            _timer.Tick += (sender, args) => Invoke(TimerTick);

            _elevatorsGrid = new bool[ConfigurationData._countFloors, ConfigurationData._countElevators];
            for (var i = 0; i < ConfigurationData._countElevators; i++)
                _elevatorsGrid[0, i] = true;
        }

        private void TimerTick()
        {
            _time += 0.1F * _simulationSpeed;
        }

        public bool[,] GetElevatorsGrid()
        {
            lock (Locker)
            {
                var elGrid = new bool[ConfigurationData._countFloors, ConfigurationData._countElevators];
                for (var i = 0; i < ConfigurationData._countFloors; i++)
                    for (var j = 0; j < ConfigurationData._countElevators; j++)
                        elGrid[i, j] = _elevatorsGrid[i, j];
                return elGrid;
            }
        }

        private static void Invoke(Action action) => action?.Invoke();

        public void InitializeElevatorRepository()
        {
            for (var i = 0; i < ConfigurationData._countElevators; i++)
                _elevatorsRepository.Add(ConfigurationData._maxAcceleration[i], ConfigurationData._maxSpeed[i],
                    ConfigurationData._capacity[i]);
        }

        public void StartSimulation()
        {
            _simulationStart = DateTime.Now;
            //_elevatorsMoveTime = new DateTime[ConfigurationData._countElevators];
            _timer.Start();
            _updateTimer.Start();
            _time = 0;
            _simulationStart = DateTime.Now;
            _thread = new Thread(ElevatorsMovingCycle)
            {
                IsBackground = true
            };
            _thread.Start();
        }
        
        public void ElevatorsMovingCycle()
        {
            var elevatorsList = (List<Elevator>)_elevatorsRepository.GetAll();
            while (true)
            {
                foreach (var elevator in elevatorsList)
                {
                    Decide(elevator);
                    MoveElevator(elevator);
                }
                Thread.Sleep(50);
            }
        }

        public void Decide(Elevator elevator)
        {
            lock(FloorService.Locker)
            {
                var requestsAbove = false;
                var requestsBelow = false;
                var nearestHigherRequest = 0;
                var nearestLowerRequest = 0;
                var currentFloor = _floorRepository.Find(elevator.CurrentFloor);

                var isElevatorFull = (elevator.MaxCapacity == elevator.CountPeople);
                //Console.WriteLine( isElevatorFull.ToString() );

                if (IsFire)
                {
                    if (!elevator.DestinationFloor[0]) elevator.DestinationFloor[0] = true;
                    if (elevator.Direction == Direction.Up)
                    {
                        elevator.Direction = Direction.Stop;
                        return;
                    }
                    else if (elevator.Direction != Direction.Up && elevator.CurrentFloor != 1)
                    {
                        elevator.Direction = Direction.Down;
                        return;
                    }
                }

                if ((elevator.CurrentFloor == ConfigurationData._countFloors &&
                     elevator.Direction == Direction.Up) ||
                    (elevator.CurrentFloor == 1 &&
                     elevator.Direction == Direction.Down))
                {
                    elevator.Direction = Direction.Stop;
                }

                //Console.WriteLine(elevator.Direction.ToString());


                if (elevator.DestinationFloor[elevator.CurrentFloor - 1])
                {
                    elevator.DestinationFloor[elevator.CurrentFloor - 1] = false;
                    //elevator._isOpenDoor = true;
                    //isUnload = true;
                    //Console.WriteLine("UNLOAD!!!!!!");

                    elevator.UnLoadingTimer = 3;
                    return;
                }

                if ((currentFloor.PeopleDirection == PeopleDirection.Up ||
                     currentFloor.PeopleDirection == PeopleDirection.Booth) &&
                    (elevator.Direction == Direction.Up || elevator.Direction == Direction.Stop) &&
                    !isElevatorFull)
                {
                    elevator.Direction = Direction.Up;
                    //isLoad = true;
                    Console.WriteLine("LOAD!!!!!!");
                    elevator.LoadingTimer = 3;
                    return;
                }
                if ((currentFloor.PeopleDirection == PeopleDirection.Down ||
                     currentFloor.PeopleDirection == PeopleDirection.Booth) &&
                    (elevator.Direction == Direction.Down || elevator.Direction == Direction.Stop) &&
                    !isElevatorFull)
                {
                    elevator.Direction = Direction.Down;
                    //isLoad = true;
                    //Console.WriteLine("LOAD(DOWN)!!!!!!");
                    elevator.LoadingTimer = 3;
                    return;
                }

                var destinationAbove = false;
                var destinationBelow = false;

                for (var i = elevator.CurrentFloor; i < ConfigurationData._countFloors; i++)
                {
                    if (elevator.DestinationFloor[i]) destinationAbove = true;

                    if (!_floorRepository.Find(i + 1).IsRequested || isElevatorFull) continue;
                    requestsAbove = true;

                    if (nearestHigherRequest == 0)
                        nearestHigherRequest = i + 1;
                }
                for (var i = elevator.CurrentFloor - 2; i >= 0; i--)
                {
                    if (elevator.DestinationFloor[i])
                    {
                        destinationBelow = true;
                        //Console.WriteLine("{P1!!!!!!");
                    }

                    if (!_floorRepository.Find(i + 1).IsRequested || isElevatorFull) continue;
                    requestsBelow = true;
                    //Console.WriteLine("{P2!!!!!!");
                    if (nearestLowerRequest == 0)
                        nearestLowerRequest = i + 1;
                }
                if (!destinationAbove && !requestsAbove &&
                    !destinationBelow && !requestsBelow)
                {
                    elevator.Direction = Direction.Stop;
                    //Console.WriteLine("STOP!!!!!!");
                    return;
                }
                if (destinationAbove && (elevator.Direction == Direction.Stop ||
                                         elevator.Direction == Direction.Up))
                {
                    elevator.Direction = Direction.Up;
                    return;
                }
                if (destinationBelow && (elevator.Direction == Direction.Stop ||
                    elevator.Direction == Direction.Down))
                {
                    elevator.Direction = Direction.Down;
                    return;
                }

                var elevatorsBetweenDown = false;
                var elevatorsBetweenUp = false;
                var elevatorsOppositeDown = false;
                var elevatorsOppositeUp = false;
                var elevatorList = (List<Elevator>)_elevatorsRepository.GetAll();

                for (var i = 0; i < ConfigurationData._countElevators; i++)
                {
                    if (elevatorList[i].Id == elevator.Id) continue;
                    var oppositeFloor = elevatorList[i].CurrentFloor;
                    var oppositeDirection = elevatorList[i].Direction;
                    if ((oppositeDirection == Direction.Up || oppositeDirection == Direction.Stop) && requestsAbove)
                    {
                        if ((oppositeFloor > elevator.CurrentFloor && oppositeFloor <= nearestHigherRequest) ||
                            (oppositeFloor == elevator.CurrentFloor && i < elevator.Id))
                            elevatorsBetweenUp = true;
                    }
                    if ((oppositeDirection == Direction.Down || oppositeDirection == Direction.Stop) && requestsBelow)
                    {
                        if ((oppositeFloor < elevator.CurrentFloor && oppositeFloor >= nearestLowerRequest) ||
                            (oppositeFloor == elevator.CurrentFloor && i < elevator.Id))
                            elevatorsBetweenDown = true;
                    }
                    if ((oppositeDirection == Direction.Up || oppositeDirection == Direction.Stop) && requestsBelow)
                    {
                        if (nearestLowerRequest >= oppositeFloor && nearestLowerRequest - oppositeFloor < elevator.CurrentFloor - nearestLowerRequest)
                            elevatorsOppositeUp = true;
                    }
                    if ((oppositeDirection == Direction.Down || oppositeDirection == Direction.Stop) && requestsAbove)
                    {
                        if (nearestLowerRequest <= oppositeFloor && oppositeFloor - nearestLowerRequest < nearestLowerRequest - elevator.CurrentFloor)
                            elevatorsOppositeDown = true;
                    }

                }
                if ((elevator.Direction == Direction.Up || elevator.Direction == Direction.Stop) &&
                    requestsAbove && !elevatorsBetweenUp && !elevatorsOppositeDown)
                {
                    elevator.Direction = Direction.Up;
                    return;
                }
                if ((elevator.Direction == Direction.Down || elevator.Direction == Direction.Stop) &&
                    requestsBelow && !elevatorsBetweenDown && !elevatorsOppositeUp)
                {
                    elevator.Direction = Direction.Down;
                    return;
                }
                elevator.Direction = Direction.Stop;
            }
            
        }

        public void MoveElevator(Elevator elevator)
        {
            if (elevator.Direction == Direction.Stop)
            {
                
                elevator.StartMovingTime = 0;
                elevator.MovingTime = 0;
                elevator.Speed = 0;
                elevator.StartMovingPosition = elevator.Position;
            }

            if (elevator.LoadingTimer > 0)
            {
                if (elevator.LoadingTimer == 3)
                {
                    elevator.StartMovingTime = 0;
                    elevator.MovingTime = 0;
                    elevator.Speed = 0;
                    elevator.StartMovingPosition = elevator.Position;
                    Floor floor;
                    lock (FloorService.Locker)
                    {
                        floor = _floorRepository.Find(elevator.CurrentFloor);
                    }
                    
                    for (var i = 0; i < floor.CountPeople && elevator.CountPeople != elevator.MaxCapacity; i++)
                    {
                        var people = floor.GetPeople(i);
                        if ((people.DestinationFloor - people.CurrentFloor > 0 && elevator.Direction == Direction.Up) ||
                            (people.DestinationFloor - people.CurrentFloor < 0 && elevator.Direction == Direction.Down))
                        {                           
                            lock (FloorService.Locker)
                            {
                                elevator.DestinationFloor[people.DestinationFloor - 1] = true;
                                elevator.AddNextPeople(people);
                                floor.RemovePeople(people);
                                elevator.CountPeople++;
                                floor.CountPeople--;
                                i--;
                                people.Status = PeopleStatus.Moving;
                                people.IsInElevator = true;
                            }
                            
                        }
                        
                        
                    }

                    lock (FloorService.Locker)
                    {
                        floor.PeopleDirection = PeopleDirection.NoDirection;

                        if (floor.CountPeople == 0)
                        {
                            floor.IsRequested = false;
                        }
                        else
                        {
                            for (var i = 0; i < floor.CountPeople; i++)
                            {
                                //var people = floor.PeekNextPeople();
                                var people = floor.GetPeople(i);
                                //Console.WriteLine(i);
                                if (people.DestinationFloor - floor.Id < 0) _floorRepository.UpdatePeopleDirection(floor.Id, PeopleDirection.Down);
                                if (people.DestinationFloor - floor.Id > 0) _floorRepository.UpdatePeopleDirection(floor.Id, PeopleDirection.Up);
                            }
                        }
                    }
                    
                }
                elevator.LoadingTimer--;
                //isLoad = false;
                return;
            }
            if (elevator.UnLoadingTimer > 0)
            {
                if (elevator.UnLoadingTimer == 3)
                {
                    elevator.StartMovingTime = 0;
                    elevator.MovingTime = 0;
                    elevator.Speed = 0;
                    elevator.StartMovingPosition = elevator.Position;
                    var n = elevator.CountPeople;

                    for (var i = 0; i < elevator.CountPeople; i++)
                    {
                        var people = elevator.GetPeople(i);
                        if ((people.DestinationFloor == elevator.CurrentFloor && !IsFire) ||
                             (IsFire && elevator.CurrentFloor == 1))
                        {
                            //_peopleRepository.Delete(elevator.GetNextPeople());
                            people.Status = PeopleStatus.Exit;
                            people.IsInElevator = false;
                            people.IsArrived = true;
                            people.ArrivingTime = _time;
                            elevator.RemovePeople(people);
                            if(IsFire)elevator.DestinationFloor[people.DestinationFloor - 1] = false; //!!!!
                            elevator.CountPeople--;
                            i--;
                        }
                    }
                    elevator.DestinationFloor[elevator.CurrentFloor - 1] = false;

                }
                //isUnload = false;
                elevator.UnLoadingTimer--;
                return;
            }

            if (elevator.StartMovingTime == 0 && elevator.Direction != Direction.Stop )
            {
                elevator.StartMovingTime = _time;
                //elevator.StartMovingPosition = elevator.Position;
            }
            else if (elevator.StartMovingTime != 0) 
                elevator.MovingTime = _time - elevator.StartMovingTime;

            if (elevator.Speed < elevator.MaxSpeed) elevator.Speed = elevator.MaxAcceleration * elevator.MovingTime;
            if (elevator.Speed > elevator.MaxSpeed) elevator.Speed = elevator.MaxSpeed;

            switch (elevator.Direction)
            {
                case Direction.Up:


                    elevator.Position = elevator.StartMovingPosition + elevator.Speed * elevator.MovingTime;

                    if( elevator.Position/_floorHeight >= elevator.CurrentFloor+1 )
                    {
                        //Console.WriteLine("2");
                        lock (Locker)
                        {
                            _elevatorsGrid[elevator.CurrentFloor - 1, elevator.Id - 1] = false;
                        }
                        elevator.CurrentFloor++;
                        lock (Locker)
                        {
                            _elevatorsGrid[elevator.CurrentFloor - 1, elevator.Id - 1] = true;
                        }
                    }
                    break;
                case Direction.Down:



                    elevator.Position = elevator.StartMovingPosition - elevator.Speed * elevator.MovingTime;
                    if(elevator.Position / _floorHeight <= elevator.CurrentFloor -1)
                    {
                        lock (Locker)
                        {
                            _elevatorsGrid[elevator.CurrentFloor - 1, elevator.Id - 1] = false;
                        }
                        elevator.CurrentFloor--;
                        lock (Locker)
                        {
                            _elevatorsGrid[elevator.CurrentFloor - 1, elevator.Id - 1] = true;
                        }
                    }
                    break;
            }

        }

        public void StopSimulation()
        {
            if (_thread.IsAlive)
            {
                if (!_timer.Enabled) _thread.Resume();
                _thread.Abort();
            }
        }

        public void PlayPauseSimulation()
        {
            if (_timer.Enabled)
            {
                _thread.Suspend();
                _timer.Enabled = false;
                _updateTimer.Enabled = false;
            }
            else
            {
                _thread.Resume();
                _timer.Enabled = true;
                _updateTimer.Enabled = true;
            }
        }

        public void SpeedUp()
        {
            if (_simulationSpeed < 4) _simulationSpeed *= 2;
        }

        public void SlowDown()
        {
            if (_simulationSpeed > 0.25) _simulationSpeed /= 2;
        }

        public bool Fire()
        {
            if (!IsFire)
            {
                IsFire = true;
                return true;
            }
            else if (_peopleRepository.GetPeopleCount() == 0)
            {
                IsFire = false;
                return true;
            } 
            else return false;
        }
    }
}
