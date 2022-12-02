using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.Clubmember
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
        public string SearchCriteria { get; set; }


        public IActionResult OnGet()
        {
            ClubMembers = memberRepository.GetAllClubMembers();
            if (!string.IsNullOrEmpty(SearchCriteria))
            {
                ClubMembers = memberRepository.SearchForClubMember(SearchCriteria);
            }

            return Page();
        }
    }
}
