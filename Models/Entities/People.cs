namespace Models.Entities
{
    public class People
    {
        private int _id;
        public int _ID
        {
            get
            {
                return _id;
            }
        }
        private int _currentFloor;
        public int _CurrentFloor
        {
            get
            {
                return _currentFloor;
            }
            set
            {
                _currentFloor = value;
            }
        }

        private int _destinationFloor;
        public int _DestinationFloor
        {
            get
            {
                return _destinationFloor;
            }
            set
            {
                _destinationFloor = value;
            }
        }

        public People(int id, int currentFloor, int destinationFloor)
        {
            _id = id;
            _currentFloor = currentFloor;
            _destinationFloor = destinationFloor;
        }
    }
}