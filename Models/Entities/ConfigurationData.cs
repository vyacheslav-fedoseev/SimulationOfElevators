using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class ConfigurationData
    {
        public static int _countFloors { get; set; }
        public static int _countElevators { get; set; }
        public static float[] _maxSpeed { get; set; }
        public static float[] _maxAcceleration { get; set; }
        public static int[] _capacity { get; set; }
        public const int MAX_COUNT_ELEVATORS = 5;
        public const int MAX_COUNT_FLOORS = 20;
    }
}
