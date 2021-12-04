using System.Collections.Generic;

namespace Models
{
    public enum Direction { UP = 0, DOWN = 1, STOP = 2 }
    public class Elevator : PlaceInfo
    {
        private int _currentFlor;
        private int _destinationFloor;
        private int _countPeople;
        public bool _isOpenDoor;
        private Direction _direction;
        public void Move()
        {

        }
        public void Decide()
        {

        }
    }
}