using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.Clubmember
{
    public class PersonalMemberPageModel : PageModel
    {
        private IClubMemberRepository memberRepo;

        [BindProperty]
        public ClubMember ClubMember { get; set; }

        public PersonalMemberPageModel(IClubMemberRepository memberRepository)
        {
            this.memberRepo = memberRepository;
        }
        public void OnGet(int id)
        {
            ClubMember = memberRepo.GetClubMember(id);
        }
    }
}
