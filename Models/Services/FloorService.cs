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
        public static Object Locker = new object();
        private readonly IFloorRepository _floorRepository;
        public FloorService(IFloorRepository floorRepository)
        {
            _floorRepository = floorRepository;  
        }

        public string[] GetFloorInfo()
        {
            string[] FloorInfo = new string[ConfigurationData._countFloors];
            for (var i = 0; i < FloorInfo.Length; i++)
            {
                FloorInfo[i] = string.Empty;
            }
            lock(Locker)
            {
                List<Floor> FloorList = (List<Floor>)_floorRepository.GetAll();

                foreach (var floor in FloorList)
                {
                    var CountPeopleDirUp = 0;
                    var CountPeopleDirDown = 0;
                    //Console.WriteLine("C = " + floor.CountPeople);

                    for (var i = 0; i < floor.CountPeople; i++)
                    {
                        if (floor.GetPeople(i).CurrentFloor > floor.GetPeople(i).DestinationFloor)
                            CountPeopleDirDown++;
                        else if (floor.GetPeople(i).CurrentFloor < floor.GetPeople(i).DestinationFloor)
                            CountPeopleDirUp++;
                    }

                    
                    if (floor.PeopleDirection == PeopleDirection.Up || floor.PeopleDirection == PeopleDirection.Booth)
                    {
                        FloorInfo[floor.Id - 1] += "Up - " + CountPeopleDirUp.ToString();
                    }
                    if (floor.PeopleDirection == PeopleDirection.Down || floor.PeopleDirection == PeopleDirection.Booth)
                    {
                        FloorInfo[floor.Id - 1] += "Down - " + CountPeopleDirDown.ToString();
                    }
                    //Console.WriteLine(FloorInfo[floor.Id - 1]);
                }
            }
            return FloorInfo;
        }

        public void InitializeFloorRepository()
        {
            for (var i = 0; i < ConfigurationData._countFloors; i++) _floorRepository.AddNewFloor();
        }
    }
}
