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
        private static List<Floor> _floor = new List<Floor>();
        private static int _id = 0;
        private const int MAX_COUNT = 20;
        public FloorRepository(int count)
        {
            for (int i = 0; i < count && i < MAX_COUNT; i++)
            {
                _floor.Add(new Floor(_id++));
            }
        }
        public Floor Find(int id)
        {
            return _floor.Find(c => c._ID == id);
        }
        public IEnumerable<Floor> GetAll()
        {
            return _floor;
        }
    }
}
