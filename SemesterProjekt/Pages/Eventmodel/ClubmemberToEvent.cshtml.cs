using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventModel : PageModel
    {
        private IEventRepository eventRepository;
        private IClubmemberEvent clubevent;
        private IClubMemberRepository memberRepository;

        public List<int> ClubmemberToEvent { get; set; }

        public ClubmemberToEventModel(IEventRepository eventRepository, IClubmemberEvent clubevent, IClubMemberRepository memberRepository)
        {
            this.eventRepository = eventRepository;
            this.clubevent = clubevent;
            this.memberRepository = memberRepository;
        }

        public void OnGet(int id )
        {
            ClubmemberToEvent = clubevent.ClubmemberList(id);
        }
    }
}
