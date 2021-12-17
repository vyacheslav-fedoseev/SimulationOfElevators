using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public enum Strategy { None = 0,  MinWaitingTime = 1, MinIdleRides = 2}
    public class ConfigurationData
    {
        public static int _countFloors;
        public static int _countElevators;
        public static float[] _maxSpeed;
        public static float[] _maxAcceleration;
        public static int[] _capacity;
        public const int MAX_COUNT_ELEVATORS = 5;
        public const int MAX_COUNT_FLOORS = 20;
        public static Strategy _strategy;
    }
}
