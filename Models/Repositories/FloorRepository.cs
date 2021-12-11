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
        private static readonly List<Floor> Floor = new List<Floor>();
        private static int _id = 1;

        public void AddNewFloor() => Floor.Add(new Floor(_id++));
        public Floor Find(int id) => Floor.Find(c => c.Id == id);
        public IEnumerable<Floor> GetAll() => Floor;
        public void UpdatePeopleDirection(int id, PeopleDirection peopleDirection)
        {
            Floor[id - 1].PeopleDirection = (Floor[id - 1].PeopleDirection == PeopleDirection.Up &&
                                             peopleDirection == PeopleDirection.Down) ||
                                            (Floor[id - 1].PeopleDirection == PeopleDirection.Down &&
                                             peopleDirection == PeopleDirection.Up) ||
                                            (peopleDirection == PeopleDirection.Booth)
                ? PeopleDirection.Booth
                : peopleDirection;
        }
    }
}
