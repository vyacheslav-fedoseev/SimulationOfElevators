using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Models.Entities;
using Models.Repositories;

namespace Models.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IFloorRepository _floorRepository;
        private List<string> _peopleStatus;
        private Thread _thread;
        private bool _isPaused = false;
        private object locker = new object();

        private void PeopleManager()
        {
            List<People> peopleList = (List<People>)_peopleRepository.GetAll();
            while(true)
            {
                for (var i=0; i< peopleList.Count; i++)
                {
                    var people = peopleList[i];
                    switch (people.Status)
                    {
                        case PeopleStatus.Choosing:
                            if( ElevatorsManager._time - people.ArrivingTime > 3F )
                            {
                                people.Status = PeopleStatus.Waiting;
                                _floorRepository.UpdatePeopleDirection(people.CurrentFloor,
                                                people.CurrentFloor < people.DestinationFloor
                                                    ? PeopleDirection.Up
                                                    : PeopleDirection.Down);
                                _floorRepository.Find(people.CurrentFloor).IsRequested = true;
                                
                            }
                            break;
                        case PeopleStatus.Waiting:
                            //string d = new Regex(@"\d+").Match(c).Value;
                            lock(locker)_peopleStatus[i] =
                                    "Человек № " + (people.Id + 1).ToString() + " : " + " ожидает лифт " + ( ElevatorsManager._time - people.EnteringTime+3).ToString() + " секунд";
                            break;
                        case PeopleStatus.Moving:
                            lock (locker) _peopleStatus[i] =
                                    "Человек № " + (people.Id + 1).ToString() + " : " + " едет на " + (people.DestinationFloor).ToString() + " этаж";
                            break;
                        case PeopleStatus.Exit:
                            lock (locker) _peopleStatus[i] =
                                    "Человек № " + (people.Id + 1).ToString() + " : " + " выходит из здания ";
                            if(ElevatorsManager._time - people.ArrivingTime > 3F)
                            {
                                _peopleRepository.Delete(people);
                                lock (locker) _peopleStatus.Remove(_peopleStatus[i]);
                                i--;
                            }
                            break;
                    }
                }
            } 
        }
        public void StartThread()
        {
            _thread = new Thread(PeopleManager)
            {
                IsBackground = true
            };
            _thread.Start();
        }
        public void StopThread()
        {
            if (_thread.IsAlive)
            {
                if (_isPaused) _thread.Resume();
                _thread.Abort();
            }
        }
        public void PlayPauseThread()
        {
            if (!_isPaused)
            {
                _thread.Suspend();
                _isPaused = true;
            }
            else
            {
                _thread.Resume();
                _isPaused = false;
            }
        }       

        public PeopleService(IPeopleRepository peopleRepository, IFloorRepository floorRepository)
        {
            _peopleRepository = peopleRepository;
            _floorRepository = floorRepository;
            _peopleStatus = new List<string>();
        }

        public string GetPeopleStatus()
        {
            var peopleStatus = string.Empty;
            lock (locker)
            {
                foreach (var element in _peopleStatus)
                {
                    peopleStatus += element + "\n";
                }
            }
            return peopleStatus;
        }

        public bool CreatePeople(int countPeople, int currentFloor, int destinationFloor)
        {
            if (currentFloor <= ConfigurationData._countFloors &&
                currentFloor > 0 &&
                destinationFloor <= ConfigurationData._countFloors &&
                destinationFloor > 0)
            {
                for (var i = 0; i < countPeople; i++)
                {
                    var id = _peopleRepository.Add(destinationFloor, currentFloor);
                    lock (locker) 
                    {
                        _floorRepository.Find(currentFloor)
                        .AddNextPeople(_peopleRepository.Find(id));

                        _peopleStatus.Add("Человек № " + (id + 1).ToString() + " : " + "выбирает номер лифта");
                    }
                    
                }

                _floorRepository.Find(currentFloor).CountPeople = countPeople;
                return true;
            }
            return false;
        }
    }
}
