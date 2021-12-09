using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public interface IFloorRepository : IRepository<Floor>
    {
        void AddNewFloor();
        void UpdatePeopleDirection(int id, PeopleDirection peopleDirection);
    }
}
