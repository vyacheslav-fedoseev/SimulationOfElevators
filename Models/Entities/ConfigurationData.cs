using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class ConfigurationData
    {
        public int _countFloors { get; set; }
        public int _countElevators { get; set; }
        public float[] _maxSpeed { get; set; }
        public float[] _maxAcceleration { get; set; }
        public int[] _capacity { get; set; }
        public const int MAX_COUNT_ELEVATORS = 5;
        public const int MAX_COUNT_FLOORS = 20;
    }
}
