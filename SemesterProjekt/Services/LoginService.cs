using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class LoginService
    {
        private ClubMember _loggedInUser;

        public void UserLogIn(ClubMember user)
        {
            _loggedInUser = user;
        }
        public void UserLogOut()
        {
            _loggedInUser = null;
        }
        public ClubMember GetLoggedUser()
        {
            return _loggedInUser;
        }
    }
}
