using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Clubmember
{
    public class DeleteMemberModel : PageModel
    {
        private IClubMemberRepository repo;

        [BindProperty]
        public ClubMember ClubMember { get; set; }
        public DeleteMemberModel(IClubMemberRepository clubMemberRepository)
        {
            this.repo = clubMemberRepository;
        }
        public void OnGet(int id)
        {
            ClubMember = repo.GetClubMember(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.DeleteClubMember(ClubMember.Id);
            return RedirectToPage("Index");
        }
    }
}
