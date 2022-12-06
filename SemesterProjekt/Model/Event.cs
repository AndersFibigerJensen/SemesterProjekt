using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class Event
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        //public List<Event> joinedMembers { get; set; }
        public List<Boat> joinedBoats { get; set; }

    }
}
