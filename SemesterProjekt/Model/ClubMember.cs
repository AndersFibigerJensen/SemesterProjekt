namespace SemesterProjekt.Model
{
    public class ClubMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ClubMember(int id, string name, int age, string email, string password)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Password = password;
        }

        public ClubMember()
        {

        }
    }
}
