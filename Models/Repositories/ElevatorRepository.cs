using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Repositories
{
    public class ElevatorRepository : IElevatorRepository
    {
        private static List<Elevator> _elevator = new List<Elevator>();
        private static int _id = 1;
        public int Add(float maxAcceleration, float maxSpeed, int maxCapacity)
        {
            _elevator.Add(new Elevator(maxAcceleration, maxSpeed, maxCapacity, _id));
            return _id++;
        }
        public Elevator Find(int id)
        {
            return _elevator.Find(c => c._ID == id);
        }
        public IEnumerable<Elevator> GetAll()
        {
            return _elevator;
        }

    }
}
