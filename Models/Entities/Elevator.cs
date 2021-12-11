using System.Collections.Generic;

namespace Models.Entities
{
    public enum Direction { Up = 0, Down = 1, Stop = 2 }
    public class Elevator : PlaceInfo
    {
        public int CurrentFloor { get; set; }
        public bool[] DestinationFloor { get; set; }
        public bool IsOpenDoor { get; set; }
        public Direction Direction { get; set; }
        private float _maxAcceleration;
        private float _maxSpeed;
        private float _speed { get; set; }
        public int MaxCapacity { get; set; }
        public int CurrentCountPeople { get; set; }
        public int LoadingTimer { get; set; }
        public int UnLoadingTimer { get; set; }

        public Elevator(float maxAcceleration, float maxSpeed, int maxCapacity, int id)
        {
            _maxAcceleration = maxAcceleration;
            _maxSpeed = maxSpeed;
            MaxCapacity = maxCapacity;
            Id = id;
            Direction = Direction.Stop;
            DestinationFloor = new bool[ConfigurationData._countFloors];
            for (var i = 0; i < ConfigurationData._countFloors; i++) DestinationFloor[i] = false;
            CurrentFloor = 1;
        }

    }
}