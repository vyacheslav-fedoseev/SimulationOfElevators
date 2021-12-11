using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Models.Repositories;

namespace Models.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IFloorRepository _floorRepository;
        private Models.Entities.ConfigurationData _configurationData = new ConfigurationData();

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
                for (var i = 0; i < countPeople; i++)
                    _floorRepository.Find(currentFloor)
                        .AddNextPeople(_peopleRepository.Find(_peopleRepository.Add(destinationFloor, currentFloor)));

                _floorRepository.UpdatePeopleDirection(currentFloor,
                    currentFloor < destinationFloor 
                        ? PeopleDirection.Up 
                        : PeopleDirection.Down);
                _floorRepository.Find(currentFloor).IsRequested = true;
                _floorRepository.Find(currentFloor).CountPeople = countPeople;
                return true;
            }
            return false;
        }
    }
}
