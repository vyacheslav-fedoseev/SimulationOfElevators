namespace Models.Entities
{
    public enum PeopleDirection { UP = 0, DOWN = 1, BOOTH = 2, NODIRECTION =3}
    public class Floor : PlaceInfo
    {
        public Floor(int id)
        {
            _id = id;
        }
        public bool isRequested { get; set; }
        //public bool isRequest { get; set; }
        public PeopleDirection _peopleDirection{ get; set; }
    }
}