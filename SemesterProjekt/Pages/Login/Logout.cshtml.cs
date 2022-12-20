using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;
using SemesterProjekt.Services;

namespace SemesterProjekt.Pages.Login
{
    public class LogoutModel : PageModel
    {
        private LoginService login { get; set; }

        public LogoutModel(LoginService logIn)
        {
            login = logIn;

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            login.UserLogOut();
            return Page();
        }
    }
}
