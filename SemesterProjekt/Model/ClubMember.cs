namespace SemesterProjekt.Model
{
    public class ClubMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ClubMember(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
