using System.Collections.Generic;

namespace Models.Entities
{
    public enum Direction { UP = 0, DOWN = 1, STOP = 2 }
    public class Elevator : PlaceInfo
    {
        private int _currentFloor;
        private int _destinationFloor;
        private int _countPeople;
        public bool _isOpenDoor;
        private Direction _direction;
        private float _maxAcceleration;
        private float _maxSpeed;
        private float _speed;
        private float _startTime;
        private int _maxCapacity;



        public Elevator(float maxAcceleration, float maxSpeed, int maxCapacity, int id)
        {
            _maxAcceleration = maxAcceleration;
            _maxSpeed = maxSpeed;
            _maxCapacity = maxCapacity;
            _id = id;
        }

    }
}