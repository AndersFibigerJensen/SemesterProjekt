using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventAddModel : PageModel
    {
        private IClubmemberEvent clubeventrepo;
        private IClubMemberRepository clubrepo;
        private IEventRepository eventrepo;

        [BindProperty]
        public ClubmemberToEvent ClubmemberToEvent { get; set; }

        public ClubmemberToEventAddModel(IClubmemberEvent clubeventrepo, IClubMemberRepository clubrepo, IEventRepository eventrepo)
        {
            this.clubeventrepo = clubeventrepo;
            this.clubrepo = clubrepo;
            this.eventrepo = eventrepo;
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
