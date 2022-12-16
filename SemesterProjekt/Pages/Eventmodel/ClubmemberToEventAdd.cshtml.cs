using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventAddModel : PageModel
    {
        private IClubmemberEvent clubeventrepo;
        private IClubMemberRepository clubrepo;
        private IEventRepository eventrepo;

        public SelectList ClubmemberNames { get; set; }

        public SelectList EventNames { get; set; }

        [BindProperty]
        public ClubmemberToEvent ClubmemberToEvent { get; set; }

        public ClubmemberToEventAddModel(IClubmemberEvent clubeventrepo, IClubMemberRepository clubrepo, IEventRepository eventrepo)
        {
            this.clubeventrepo = clubeventrepo;
            this.clubrepo = clubrepo;
            this.eventrepo = eventrepo;
            List<ClubMember> members= clubrepo.GetAllClubMembers();
            List<Event> Events = eventrepo.GetAllEvents();
            ClubmemberNames = new SelectList(Events, "Id", "Name");
            EventNames = new SelectList(members, "Id", "Name");
        }

        public void OnGet(int id)
        {
            ClubmemberToEvent= clubeventrepo.GetClubmemberToEvent(id);
        }

        public IActionResult Onpost()
        {
            clubeventrepo.AddClubmemberToEvent(ClubmemberToEvent);
            return RedirectToPage("ClubmemberToEvent");
        }
    }
}
