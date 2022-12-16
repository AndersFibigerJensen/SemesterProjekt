using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventDeleteModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IClubmemberEvent _clubeventrepo;
        private IClubMemberRepository _clubrepo;

        [BindProperty]
        public ClubmemberToEvent ClubmemberToEvent { get; set; }

        public SelectList ClubmemberNames { get; set; }

        public SelectList EventNames { get; set; }

        public ClubmemberToEventDeleteModel(IEventRepository eventRepository, IClubmemberEvent clubeventrepo, IClubMemberRepository clubrepo)
        {
            _eventRepository = eventRepository;
            _clubeventrepo = clubeventrepo;
            _clubrepo = clubrepo;
        }

        public void OnGet(int id)
        {
            ClubmemberToEvent=_clubeventrepo.GetClubmemberToEvent(id);
        }

        public IActionResult Onpost()
        {
            _clubeventrepo.EditClubmemberToEvent(ClubmemberToEvent);
            return RedirectToPage("ClubmemberToEvent");
        }


    }
}
