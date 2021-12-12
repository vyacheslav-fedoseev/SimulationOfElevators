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
        private float _time;
        private readonly bool[,] _elevatorsGrid;
        private bool _isPause;
        public event Action DataUpdated;

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

            _timer = timer;
            _timer.Interval = 100;
            _timer.Tick += (sender, args) => Invoke(TimerTick);

            _elevatorsGrid = new bool[ConfigurationData._countFloors, ConfigurationData._countElevators];
            for (var i = 0; i < ConfigurationData._countElevators; i++)
                _elevatorsGrid[0, i] = true;
            _isPause = false;
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
                Thread.Sleep(100);
            }
        }

        public void Decide(Elevator elevator)
        {
            var requestsAbove = false;
            var requestsBelow = false;
            var nearestHigherRequest = 0;
            var nearestLowerRequest = 0;
            var currentFloor = _floorRepository.Find(elevator.CurrentFloor);

            if ((elevator.CurrentFloor == ConfigurationData._countFloors &&
                 elevator.Direction == Direction.Up) ||
                (elevator.CurrentFloor == 1 &&
                 elevator.Direction == Direction.Down)) elevator.Direction = Direction.Stop;
            if (elevator.DestinationFloor[elevator.CurrentFloor - 1])
            {
                elevator.DestinationFloor[elevator.CurrentFloor - 1] = false;
                //elevator._isOpenDoor = true;
                //isUnload = true;
                elevator.UnLoadingTimer = 3;
                return;
            }
            if ((currentFloor.PeopleDirection == PeopleDirection.Up ||
                 currentFloor.PeopleDirection == PeopleDirection.Booth) &&
                (elevator.Direction == Direction.Up || elevator.Direction == Direction.Stop))
            {
                elevator.Direction = Direction.Up;
                //isLoad = true;
                Console.WriteLine("LOAD!!!!!!");
                elevator.LoadingTimer = 3;
                return;
            }
            if ((currentFloor.PeopleDirection == PeopleDirection.Down ||
                 currentFloor.PeopleDirection == PeopleDirection.Booth) &&
                (elevator.Direction == Direction.Down || elevator.Direction == Direction.Stop))
            {
                elevator.Direction = Direction.Down;
                //isLoad = true;
                Console.WriteLine("LOAD(DOWN)!!!!!!");
                elevator.LoadingTimer = 3;
                return;
            }

            var destinationAbove = false;
            var destinationBelow = false;

            for (var i = elevator.CurrentFloor; i < ConfigurationData._countFloors; i++)
            {
                if (elevator.DestinationFloor[i]) destinationAbove = true;

                if (!_floorRepository.Find(i + 1).IsRequested) continue;
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

                if (!_floorRepository.Find(i + 1).IsRequested) continue;
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

                    var floor = _floorRepository.Find(elevator.CurrentFloor);
                    for (var i = 0; i < floor.CountPeople; i++)
                    {
                        var people = floor.GetNextPeople();
                        elevator.DestinationFloor[people.DestinationFloor - 1] = true;
                        elevator.AddNextPeople(people);
                    }
                    floor.IsRequested = false;
                    floor.PeopleDirection = PeopleDirection.NoDirection;
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

                    for (var i = 0; i < elevator.CountPeople; i++)
                    {
                        var people = elevator.PeekNextPeople();
                        if (people.DestinationFloor == elevator.CurrentFloor)
                        {
                            _peopleRepository.Delete(elevator.GetNextPeople());
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
                    Console.WriteLine(elevator.Position.ToString());
                    Console.WriteLine(elevator.Speed.ToString());
                    Console.WriteLine(elevator.Direction.ToString());
                    //Console.WriteLine(elevator.Speed.ToString());
                    //Console.WriteLine(elevator.MovingTime.ToString());

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

                    Console.WriteLine(elevator.Position.ToString());
                    Console.WriteLine(elevator.Speed.ToString());
                    Console.WriteLine(elevator.Direction.ToString());

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
            _thread.Abort();
        }

        public void PlayPauseSimulation()
        {
            if (!_isPause)
            {
                _thread.Suspend();
                _timer.Enabled = false;
                _updateTimer.Enabled = false;
                _isPause = true;
            }
            else
            {
                _thread.Resume();
                _timer.Enabled = true;
                _updateTimer.Enabled = true;
                _isPause = false;
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
    }
}
