using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public class FloorRepository : IFloorRepository
    {
        private static List<Floor> _floor = new List<Floor>();
        private static int _id = 0;
        
        public void AddNewFloor()
        {
            _floor.Add(new Floor(_id++));
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
