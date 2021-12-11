namespace Models.Entities
{
    public class People
    {
        public int Id { get; }
        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }

        public People(int id, int currentFloor, int destinationFloor)
        {
            Id = id;
            CurrentFloor = currentFloor;
            DestinationFloor = destinationFloor;
        }
    }
}