namespace SemesterProjekt.Model
{
    public class Instructor : ClubMember
    {
        //List<Boat> TeachingVerified { get; set; }

        public Instructor(int id, string name, int age, string email, string password, string memberImage) : base (id, name, age, email, password, memberImage)
        {

        }
    }
}
