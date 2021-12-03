using System.Collections.Generic;

namespace Models
{
    public enum Direction { UP = 0, DOWN = 1, STOP = 2 }
    internal class CElevator : CPlaceInfo
    {
        private int currentFlor;
        private int destinationFloor;
        private int countPeople;
        private Direction direction;
        public bool isOpenDoor;
        public void Move()
        {

        }
        public void Decide()
        {

        }
    }
}