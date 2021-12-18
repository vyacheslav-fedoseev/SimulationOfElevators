using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;
using Models.Entities;

namespace Models.Services
{
    public class FloorService : IFloorService
    {
        public static object Locker = new object();
        private readonly IFloorRepository _floorRepository;
        public FloorService(IFloorRepository floorRepository)
        {
            _floorRepository = floorRepository;  
        }

        public string[] GetFloorInfo()
        {
            var floorInfo = new string[ConfigurationData.CountFloors];
            for (var i = 0; i < floorInfo.Length; i++)
            {
                floorInfo[i] = string.Empty;
            }
            lock(Locker)
            {
                List<Floor> floorList = (List<Floor>)_floorRepository.GetAll();

                foreach (var floor in floorList)
                {
                    var countPeopleDirUp = 0;
                    var countPeopleDirDown = 0;

                    for (var i = 0; i < floor.CountPeople; i++)
                    {
                        if (floor.GetPeople(i).CurrentFloor > floor.GetPeople(i).DestinationFloor)
                            countPeopleDirDown++;
                        else if (floor.GetPeople(i).CurrentFloor < floor.GetPeople(i).DestinationFloor)
                            countPeopleDirUp++;
                    }

                    if (floor.PeopleDirection == PeopleDirection.Up || floor.PeopleDirection == PeopleDirection.Booth)
                        floorInfo[floor.Id - 1] += "Up - " + countPeopleDirUp.ToString();
                    if (floor.PeopleDirection == PeopleDirection.Down || floor.PeopleDirection == PeopleDirection.Booth)
                        floorInfo[floor.Id - 1] += "Down - " + countPeopleDirDown.ToString(); ;
                }
            }
            return floorInfo;
        }

        public void InitializeFloorRepository()
        {
            for (var i = 0; i < ConfigurationData.CountFloors; i++) 
                _floorRepository.AddNewFloor();
        }
    }
}
