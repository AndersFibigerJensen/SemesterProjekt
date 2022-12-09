using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;
using SemesterProjekt.Services;

namespace SemesterProjekt.Pages.Login
{
    public class IndexModel : PageModel
    {
        private IClubMemberRepository userService;
        private LoginService loginService;
        public string AccessDenied = "";
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IndexModel(IClubMemberRepository service, LoginService logIn)
        {
            userService = service;
            loginService = logIn;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            foreach (ClubMember user in userService.GetAllClubMembers())
            {
                if (user.Email == Email)
                {
                    if(user.Password == Password)
                    {
                        loginService.UserLogIn(user);
                        return RedirectToPage("/Index");
                    }
                }
                AccessDenied = "Email/password does not match an existing user.";
            }
            return Page();
        }
    }
}
