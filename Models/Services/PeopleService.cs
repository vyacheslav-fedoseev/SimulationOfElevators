using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;

namespace Models.Services
{
    public class PeopleService : IPeopleService
    {
        private static PeopleRepository _peopleRepository = new PeopleRepository();
        private static FloorRepository _floorRepository;

        public bool CreatePeople(int countPeople, int currentFloor, int destinationFloor)
        {
            return false;
            for (int i = 0; i < countPeople; i++)
            {

            }

        }
    }
}
