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
        private static int _id = 1;
        
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
        public void UpdatePeopleDirection( int id , PeopleDirection peopleDirection)
        {
            if ((_floor[id]._peopleDirection == PeopleDirection.UP && peopleDirection == PeopleDirection.DOWN) ||
                (_floor[id]._peopleDirection == PeopleDirection.DOWN && peopleDirection == PeopleDirection.UP) ||
                    (peopleDirection == PeopleDirection.BOOTH))
                _floor[id]._peopleDirection = PeopleDirection.BOOTH;
            else _floor[id]._peopleDirection = peopleDirection;
        }
    }
}
