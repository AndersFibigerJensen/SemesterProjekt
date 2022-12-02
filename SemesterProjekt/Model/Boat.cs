namespace SemesterProjekt.Model
{
    public class Boat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Weight { get; set; }

        public double TopSpeed { get; set; }

        public int MinimumCrew { get; set; } 

        public List<ClubMember> Crewlist { get; set; }

        public Boat()
        {
            Crewlist = new List<ClubMember>();
        }

    }
}
