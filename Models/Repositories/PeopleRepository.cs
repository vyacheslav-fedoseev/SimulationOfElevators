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
        private static List<People> _people = new List<People>();
        private static int _id = 0;

        public int Add(int destinationFloor, int currentFloor)
        {
            _people.Add(new People(_id, currentFloor, destinationFloor));
            return _id++;
        }
        public int GetPeopleCount() => _people.Count;
        public People Find(int id) => _people.Find(c => c.Id == id);
        public bool Delete(People obj) => _people.Remove(obj);
        public IEnumerable<People> GetAll() => _people;
        public void Clear() => _people = new List<People>();
    }
}
