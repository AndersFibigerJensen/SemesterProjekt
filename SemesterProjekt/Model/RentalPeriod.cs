namespace SemesterProjekt.Model
{
    public class RentalPeriod
    {
        public int Id { get; set; }

        public DateTime Rentalperiod { get; set; }

        public bool Verification { get; set; }

        public CrewMember CrewMember { get; set; }

    }
}
