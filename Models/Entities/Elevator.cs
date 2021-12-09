using System.Collections.Generic;

namespace Models.Entities
{
    public enum Direction { UP = 0, DOWN = 1, STOP = 2 }
    public class Elevator : PlaceInfo
    {
        public int _currentFloor { get; set; }
        public bool[] _destinationFloor { get; set; }
        
        public bool _isOpenDoor { get; set; }
        public Direction _direction { get; set; }
        private float _maxAcceleration;
        private float _maxSpeed;
        private float _speed { get; set; }
        public int _maxCapacity { get; set; }
        public int _currentCountPeople { get;  set; }

        public int _loadingTimer { get; set; }
        public int _unLoadingTimer { get; set; }



        public Elevator(float maxAcceleration, float maxSpeed, int maxCapacity, int id)
        {
            _maxAcceleration = maxAcceleration;
            _maxSpeed = maxSpeed;
            _maxCapacity = maxCapacity;
            _id = id;
            _direction = Direction.STOP;
            _destinationFloor = new bool[ConfigurationData._countFloors];
            _currentFloor = 1;
        }

    }
}