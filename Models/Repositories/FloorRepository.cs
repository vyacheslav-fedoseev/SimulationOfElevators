using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    class FloorRepository : IFloorRepository
    {
        private static Floor[] _floor;
        public FloorRepository(int count)
        {
            _floor = new Floor[count];
        }
        public Floor Find(int id)
        {
            return _floor[id];
        }
        public IEnumerable<Floor> GetAll()
        {
            return _floor;
        }

    }
}
