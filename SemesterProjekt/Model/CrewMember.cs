namespace SemesterProjekt.Model
{
    public class CrewMember : ClubMember
    {
        public bool SeniorCertified { get; set; }
        //public List<Boat> BoatVerified { get; set; }
        public CrewMember(bool seniorCertified, int id, string name, int age, string email, string password, string memberImage ) : base(id, name, age, email, password, memberImage)
        {
            SeniorCertified = seniorCertified;
        }
    }
}
