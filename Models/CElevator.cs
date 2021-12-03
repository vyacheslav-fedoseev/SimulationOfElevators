using System.Collections.Generic;

namespace Models
{
    public enum Direction { UP = 0, DOWN = 1, STOP = 2 }
    public class CElevator
    {
        private int number;
        private int currentFlor;
        private int destinationFloor;
        private int countPeople;
        private Direction direction;
        private Queue<CPeople> people;
        public bool isOpenDoor;
        public void Move()
        {

        }
    }
}