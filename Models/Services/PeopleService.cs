using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;
using Models.Entities;

namespace Models.Services
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepository _peopleRepository;
        private IFloorRepository _floorRepository;
        private ConfigurationData _configurationData = new ConfigurationData();

        public PeopleService(IPeopleRepository peopleRepository, IFloorRepository floorRepository)
        {
            _peopleRepository = peopleRepository;
            _floorRepository = floorRepository;
        }
        public bool CreatePeople(int countPeople, int currentFloor, int destinationFloor)
        {
            if (currentFloor <= ConfigurationData._countFloors &&
                currentFloor > 0 &&
                destinationFloor <= ConfigurationData._countFloors &&
                destinationFloor > 0)
            {
                /*for (int i = 0; i < countPeople; i++)
                {
                    _floorRepository.Find(currentFloor).AddNextPeople(_peopleRepository.Find(_peopleRepository.Add(destinationFloor, currentFloor)));
                }*/

                _peopleRepository.Add(destinationFloor, currentFloor);

                if (currentFloor < destinationFloor) _floorRepository.UpdatePeopleDirection(currentFloor, PeopleDirection.UP);
                else _floorRepository.UpdatePeopleDirection(currentFloor, PeopleDirection.DOWN);
                _floorRepository.Find(currentFloor).isRequested = true;

            return true;
            }
            else
                return false;
            

        }
    }
}
