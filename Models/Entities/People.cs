using Models.Services;

namespace Models.Entities
{
    public enum PeopleStatus { Choosing = 0, Waiting = 1, Moving = 2, Exit = 3 }
    public class People
    {
        public int Id { get; }
        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }
        public float EnteringTime { get; set; }
        public float ArrivingTime { get; set; }
        public PeopleStatus Status { get; set; }

        public People(int id, int currentFloor, int destinationFloor)
        {
            Id = id;
            CurrentFloor = currentFloor;
            DestinationFloor = destinationFloor;
            Status = PeopleStatus.Choosing;
            EnteringTime = ElevatorsManager._time;
        }
    }
}