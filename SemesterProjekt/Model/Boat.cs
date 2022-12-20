using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SemesterProjekt.Model
{
    public class Boat
    {
        //Anders//

        [Required]
        [Range(typeof(int), "1", "1000", ErrorMessage = "Id er uden for intervallet")]
        public int Id { get; set; }

        [Required(ErrorMessage = "du skal skrive et navn")]
        public string Name { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Weight { get; set; }

        public int MinimumCrew { get; set; }

       
        public BoatType BoatType {get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Boat other = (Boat)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
