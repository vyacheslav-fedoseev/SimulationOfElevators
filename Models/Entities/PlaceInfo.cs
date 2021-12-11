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
        protected Queue<People> People = new Queue<People>();

        public People GetNextPeople() => People.Dequeue();
        public People PeekNextPeople() => People.Peek();
        public void AddNextPeople(People people) => People.Enqueue(people);
    }
}
