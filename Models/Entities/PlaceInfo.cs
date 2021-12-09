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
        protected int _countPeople;

        public int _CountPeople
        {
            get
            {
                return _countPeople;
            }
            set
            {
                _countPeople = value;
            }
        }

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
        public People PeekNextPeople()
        {
            return _people.Peek();
        }

        public void AddNextPeople(People people)
        {
           _people.Enqueue(people);
        }
    }
}
