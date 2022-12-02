using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.Clubmember
{
    public class AddMemberModel : PageModel
    {
        private IClubMemberRepository repo;
        
        [BindProperty]
        public ClubMember ClubMember { get; set; }

        public AddMemberModel(IClubMemberRepository clubMemberRepository)
        {
            repo = clubMemberRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddClubMember(ClubMember);
            return RedirectToPage("Index");

        }
    }
}
