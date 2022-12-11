using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class Event
    {
        [Required]
        [Range(typeof(int), "1", "1000", ErrorMessage = "Id er uden for intervallet")]
        public int Id { get; set; }


        [Required(ErrorMessage = "du skal skrive et navn")]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime FromDate { get; set; }

        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime ToDate { get; set; }

        //public List<ClubMember> joinedMembers { get; set; }
        public List<Boat> joinedBoats { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Event other = (Event)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
