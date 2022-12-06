using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class RentalPeriod
    {
        [Required]
        [Range(typeof(int), "1", "1000", ErrorMessage = "Id er uden for intervallet")]
        public int Id { get; set; }

        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime RentalperiodFrom { get; set; }

        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
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
