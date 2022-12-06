using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class RentalPeriod
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime RentalperiodFrom { get; set; }

        [Required]
        public DateTime RentalperiodTo { get; set; }

        public bool Verification { get; set; }

        public CrewMember CrewMember { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                RentalPeriod other = (RentalPeriod)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }

    }
}
