namespace Models.Entities
{
    public enum PeopleDirection { Up = 0, Down = 1, Booth = 2, NoDirection = 3 }
    public class Floor : PlaceInfo
    {
        public Floor(int id)
        {
            Id = id;
            PeopleDirection = PeopleDirection.NoDirection;
            CountOfDownRequests = 0;
            CountOfUpRequests = 0;
        }
        public bool IsRequested { get; set; }

        public int CountOfUpRequests { get; set; }
        public int CountOfDownRequests { get; set; }
        public PeopleDirection PeopleDirection { get; set; }
    }
}