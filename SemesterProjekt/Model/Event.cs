namespace SemesterProjekt.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        //public List<Event> joinedMembers { get; set; }
        public List<Boat> joinedBoats { get; set; }

    }
}
