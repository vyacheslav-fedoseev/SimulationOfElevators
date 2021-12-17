using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private static List<People> People = new List<People>();
        private static int _id = 0;

        public int Add(int destinationFloor, int currentFloor)
        {
            People.Add(new People(_id, currentFloor, destinationFloor));
            return _id++;
        }
        public int GetPeopleCount() => People.Count;
        public People Find(int id) => People.Find(c => c.Id == id);
        public bool Delete(People obj) => People.Remove(obj);
        public IEnumerable<People> GetAll() => People;
        public void Clear() => People = new List<People>();
    }
}
