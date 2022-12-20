using System.ComponentModel.DataAnnotations;

namespace SemesterProjekt.Model
{
    public class ClubMember
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ClubMember(int id, string name, int age, string email, string password)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Password = password;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                ClubMember other = (ClubMember)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }

        public ClubMember()
        {

        }
    }
}
