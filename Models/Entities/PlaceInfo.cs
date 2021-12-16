using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public abstract class PlaceInfo
    {
        public int Id { get; protected set; }
        public int CountPeople { get; protected internal set; }

        protected List<People> People = new List<People>();
        public bool RemovePeople(People people) => People.Remove(people);

        public People GetPeople(int num) => People[num];
        public void AddNextPeople(People people) => People.Add(people);

        public People GetNextPeople()
        {
            var people = People[0];
            People.Remove(people);
            return people;
        }
        public People PeekNextPeople() => People[0];
    }
}
