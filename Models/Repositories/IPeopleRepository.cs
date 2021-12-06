using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public interface IPeopleRepository : IRepository<People>
    {
        int Add(int destinationFloor, int currentFloor);
        bool Delete(People obj);
    }
}
