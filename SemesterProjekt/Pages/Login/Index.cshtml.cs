using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Login
{
    public class IndexModel : PageModel
    {
        private IClubMemberRepository memberRepository;
        public IndexModel(IClubMemberRepository clubMemberRepository)
        {
            memberRepository = clubMemberRepository;
        }
        public List<ClubMember> ClubMembers { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }

        public void OnGet()
        {
        }
    }
}
