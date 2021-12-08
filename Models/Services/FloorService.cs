using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repositories;
using Models.Entities;

namespace Models.Services
{
    public class FloorService: IFloorService
    {
        private IFloorRepository _floorRepository;
        public FloorService(IFloorRepository floorRepository)
        {
            _floorRepository = floorRepository;
        }

        public void InitializeFloorRepozitory()
        {
            for (int i = 0; i < ConfigurationData._countFloors; i++)
            {
                _floorRepository.AddNewFloor();
            }
        }
    }
}
