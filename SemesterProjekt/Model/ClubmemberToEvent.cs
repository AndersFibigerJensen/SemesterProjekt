using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class ClubmemberToEvent
    {
        [Required]
        public int ClubMemberID { get; set; }

        [Required]
        public int EventID { get; set; }

        [Required]
        public int BookingID { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                ClubmemberToEvent other = (ClubmemberToEvent)obj;
                if (other.BookingID == BookingID)
                    return true;
                else
                    return false;
            }
        }
    }
}
