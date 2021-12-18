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
        public static int CountFloors;
        public static int CountElevators;
        public static float[] MaxSpeed;
        public static float[] MaxAcceleration;
        public static int[] Capacity;
        public const int MaxCountElevators = 5;
        public const int MaxCountFloors = 20;
        public static Strategy _strategy;
    }
}
