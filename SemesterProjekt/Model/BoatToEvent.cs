using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class BoatToEvent
    {
        [Required]
        public int BoatId { get; set; }

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
                BoatToEvent other = (BoatToEvent)obj;
                if (other.BookingID == BookingID)
                    return true;
                else
                    return false;
            }
        }
    }
}
