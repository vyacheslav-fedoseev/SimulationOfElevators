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
        private IElevatorRepository _elevatorsRepository;
        private IPeopleRepository _peopleRepository;
        private IFloorRepository _floorRepository;

        private Thread _thread;
        private ITimer _timer;
        private object locker = new object();

        private DateTime _simulationStart;
        private DateTime[] _elevatorsMoveTime;
        private bool[,] _elevatorsGrid;
        private bool isPause;

        //private bool isLoad;
        //private bool isUnload;
        public event Action DataUpdated;

        public ElevatorsManager(IElevatorRepository elevatorsRepository, IPeopleRepository peopleRepository, IFloorRepository floorRepository, ITimer timer)
        {
            _elevatorsRepository = elevatorsRepository;
            _peopleRepository = peopleRepository;
            _floorRepository = floorRepository;
            _timer = timer;
            _timer.Interval = 250;
            _timer.Tick += (sender, args) => Invoke(DataUpdated);
            _elevatorsGrid = new bool[ConfigurationData._countFloors, ConfigurationData._countElevators];

            for (int i = 0; i < ConfigurationData._countElevators; i++)
                _elevatorsGrid[0,i]= true;

            isPause = false;
        }

        public bool[,] GetElevatorsGrid()
        {
            lock(locker)
            {
                bool[,] elGrid = new bool[ConfigurationData._countFloors, ConfigurationData._countElevators];
                for (int i = 0; i < ConfigurationData._countFloors; i++)
                {
                    for (int j = 0; j < ConfigurationData._countElevators; j++)
                    {
                        elGrid[i, j] = _elevatorsGrid[i, j];
                    }
                }
                return elGrid;
            }
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public void InitializeElevatorRepository()
        {
            for(int i=0; i< ConfigurationData._countElevators; i++)
            {
                _elevatorsRepository.Add(ConfigurationData._maxAcceleration[i], ConfigurationData._maxSpeed[i], ConfigurationData._capacity[i]);
            }
        }

        public void StartSimulation()
        {
            _simulationStart = DateTime.Now;
            _elevatorsMoveTime = new DateTime[ConfigurationData._countElevators];
            _timer.Start();
            _thread = new Thread(ElevatorsMovingCycle);
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void ElevatorsMovingCycle()
        {
            List<Elevator> elevatorsList = (List<Elevator>)_elevatorsRepository.GetAll();
            while(true)
            {
                foreach(Elevator elevator in elevatorsList)
                {
                    Decide(elevator);
                    MoveElevator(elevator);
                }
                Thread.Sleep(200);
            }
            
        }

        public void Decide( Elevator elevator )
        {
            bool destinationAbove, destinationBelow;
            bool requestsAbove = false, requestsBelow = false;
            int nearlestHigherRequest=0, nearlestLowerRequest=0;

            bool elevatorsBetweenUp, elevatorsBetweenDown;
            bool elevatorsOpositeUp, elevatorsOpositeDown;

            Floor _currentFloor = _floorRepository.Find(elevator._currentFloor);

            

            int opositeFloor;
            Direction opositeDirection;

            if ((elevator._currentFloor == ConfigurationData._countFloors &&
                elevator._direction == Direction.UP) ||
                (elevator._currentFloor == 1 &&
                elevator._direction == Direction.DOWN)) elevator._direction = Direction.STOP;

            if (elevator._destinationFloor[elevator._currentFloor-1])
            {
                elevator._destinationFloor[elevator._currentFloor - 1] = false;
                //elevator._isOpenDoor = true;
                //isUnload = true;
                elevator._unLoadingTimer = 3;
                return;
            }
            

            if( (_currentFloor._peopleDirection == PeopleDirection.UP||
                _currentFloor._peopleDirection == PeopleDirection.BOOTH)&&
                (elevator._direction == Direction.UP || elevator._direction == Direction.STOP))
            {
                elevator._direction = Direction.UP;
                //isLoad = true;
                Console.WriteLine("Загрузка!!!!!!");
                elevator._loadingTimer = 3;
                return;
            }
            

            if ((_currentFloor._peopleDirection == PeopleDirection.DOWN ||
                _currentFloor._peopleDirection == PeopleDirection.BOOTH) &&
                (elevator._direction == Direction.DOWN || elevator._direction == Direction.STOP))
            {
                elevator._direction = Direction.DOWN;
                //isLoad = true;
                Console.WriteLine("Загрузка(низ)!!!!!!");
                elevator._loadingTimer = 3;
                return;
            }

            destinationAbove = false;
            destinationBelow = false;

            for(int i=elevator._currentFloor; i<ConfigurationData._countFloors; i++)
            {
                if (elevator._destinationFloor[i])
                {
                    destinationAbove = true;
                    
                }    
                    
                if(_floorRepository.Find(i+1).isRequested)
                {
                    requestsAbove = true;
                    
                    if (nearlestHigherRequest == 0)
                        nearlestHigherRequest = i+1;
                }
            }

            for (int i = elevator._currentFloor-2; i >= 0; i--)
            {
                if (elevator._destinationFloor[i])
                {
                    destinationBelow = true;
                    Console.WriteLine("{P1!!!!!!");
                }
                    
                if (_floorRepository.Find(i + 1).isRequested)
                {
                    requestsBelow = true;
                    Console.WriteLine("{P2!!!!!!");
                    if (nearlestLowerRequest == 0)
                        nearlestLowerRequest = i + 1;
                }
            }

            if( !destinationAbove && !requestsAbove &&
                !destinationBelow && !requestsBelow)
            {
                elevator._direction = Direction.STOP;
                Console.WriteLine("стоп!!!!!!");
                return;
            }
            

            if (destinationAbove &&(elevator._direction == Direction.STOP||
                elevator._direction == Direction.UP))
            {
                elevator._direction = Direction.UP;
                return;
            }
            if(destinationBelow && (elevator._direction == Direction.STOP ||
                elevator._direction == Direction.DOWN))
            {
                elevator._direction = Direction.DOWN;
                return;
            }

            elevatorsBetweenDown = false;
            elevatorsBetweenUp = false;
            elevatorsOpositeDown = false;
            elevatorsOpositeUp = false;

            List<Elevator> elevatorList = (List<Elevator>)_elevatorsRepository.GetAll();

            for(int i=0; i< ConfigurationData._countElevators; i++ )
            {
                if ( elevatorList[i]._ID != elevator._ID )
                {
                    opositeFloor = elevatorList[i]._currentFloor;
                    opositeDirection = elevatorList[i]._direction;
                    if ( (opositeDirection == Direction.UP|| opositeDirection == Direction.STOP) && requestsAbove)
                    {
                        if ((opositeFloor > elevator._currentFloor && opositeFloor <= nearlestHigherRequest) ||
                            (opositeFloor == elevator._currentFloor && i < elevator._ID))
                            elevatorsBetweenUp = true;
                     
                    }
                    if((opositeDirection == Direction.DOWN || opositeDirection == Direction.STOP) && requestsBelow)
                    {
                        if ((opositeFloor < elevator._currentFloor && opositeFloor >= nearlestLowerRequest) ||
                            (opositeFloor == elevator._currentFloor && i < elevator._ID))
                            elevatorsBetweenDown = true;
                    }
                    if ((opositeDirection == Direction.UP || opositeDirection == Direction.STOP) && requestsBelow)
                    {
                        if (nearlestLowerRequest >= opositeFloor && nearlestLowerRequest - opositeFloor < elevator._currentFloor - nearlestLowerRequest )
                            elevatorsOpositeUp = true;

                    }
                    if ((opositeDirection == Direction.DOWN || opositeDirection == Direction.STOP) && requestsAbove)
                    {
                        if (nearlestLowerRequest <= opositeFloor &&  opositeFloor- nearlestLowerRequest < nearlestLowerRequest - elevator._currentFloor )
                            elevatorsOpositeDown = true;

                    }

                }

            }

            if((elevator._direction == Direction.UP || elevator._direction == Direction.STOP) &&
                requestsAbove && !elevatorsBetweenUp && !elevatorsOpositeDown)
            {
                elevator._direction = Direction.UP;
                return;
            }

            if ((elevator._direction == Direction.DOWN || elevator._direction == Direction.STOP) &&
                requestsBelow && !elevatorsBetweenDown && !elevatorsOpositeUp)
            {
                elevator._direction = Direction.DOWN;
                return;
            }

            elevator._direction = Direction.STOP;
        }
        public void MoveElevator( Elevator elevator)
        {
            if(elevator._loadingTimer >0)
            {
                Console.WriteLine("ХЗ_1");
                if (elevator._loadingTimer == 3)
                {
                    Floor floor = _floorRepository.Find(elevator._currentFloor);
                    for (int i = 0; i < floor._CountPeople; i++)
                    {
                        People people = floor.GetNextPeople();
                        elevator._destinationFloor[people._DestinationFloor - 1] = true;
                        //Console.WriteLine(elevator._destinationFloor[people._DestinationFloor - 1].ToString());
                        elevator.AddNextPeople(people);
                    }
                    floor.isRequested = false;
                    floor._peopleDirection = PeopleDirection.NODIRECTION;
                }
                elevator._loadingTimer--;
                //isLoad = false;
                return;
            }
            if(elevator._unLoadingTimer>0)
            {
                if (elevator._unLoadingTimer == 3)
                {
                    for (int i = 0; i < elevator._CountPeople; i++)
                    {
                        People people = elevator.PeekNextPeople();
                        if (people._DestinationFloor == elevator._currentFloor)
                        {
                            _peopleRepository.Delete(elevator.GetNextPeople());
                        }
                    }
                    elevator._destinationFloor[elevator._currentFloor - 1] = false;
                }
                //isUnload = false;
                elevator._unLoadingTimer--;
                return;
            }

            if (elevator._direction == Direction.UP)
            {
                _elevatorsGrid[elevator._currentFloor - 1, elevator._ID - 1] = false;
                elevator._currentFloor++;
                _elevatorsGrid[elevator._currentFloor - 1, elevator._ID - 1] = true;
            }
                
            else if (elevator._direction == Direction.DOWN)
            {
                _elevatorsGrid[elevator._currentFloor - 1, elevator._ID - 1] = false;
                elevator._currentFloor--;
                _elevatorsGrid[elevator._currentFloor - 1, elevator._ID - 1] = true;
            }

        }
        public void StopSimulation()
        {
            _thread.Abort();
        }

        public void PlayPauseSimulation()
        {
            if(!isPause)
            {
                _thread.Suspend();
                _timer.Enabled = false;
                isPause = true;
            }
            else
            {
                _thread.Resume();
                _timer.Enabled = true;
                isPause = false;
            }
        }

        
    }
}
