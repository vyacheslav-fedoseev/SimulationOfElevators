using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class PlaceInfo
    {
        protected int _id;
        public int _ID
        {
            get
            {
                return _id;
            }
        }
        protected Queue<People> _people = new Queue<People>();
        public People GetNextPeople()
        {
            return _people.Dequeue();
        }

        public void AddNextPeople(People people)
        {
           _people.Enqueue(people);
        }
    }
}
