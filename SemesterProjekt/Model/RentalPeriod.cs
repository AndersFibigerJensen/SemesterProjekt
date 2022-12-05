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

    }
}
