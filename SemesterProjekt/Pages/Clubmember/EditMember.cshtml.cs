using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Clubmember
{
    public class EditMemberModel : PageModel
    {
        private IClubMemberRepository memberRepo;

        [BindProperty]
        public ClubMember ClubMember { get; set; }

        public EditMemberModel(IClubMemberRepository memberRepository)
        {
            this.memberRepo = memberRepository;
        }

        public void OnGet(int id)
        {
            ClubMember = memberRepo.GetClubMember(id);
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            memberRepo.EditClubMember(ClubMember);
            return RedirectToPage("Index");
        }
    }
}
