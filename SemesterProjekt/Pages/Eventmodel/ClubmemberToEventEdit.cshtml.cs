using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventEditModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IClubMemberRepository _clubrepo;
        private IClubmemberEvent _clubeventrepo;

        public SelectList ClubmemberNames { get; set; }

        public SelectList EventNames { get; set; }


        [BindProperty]
        public ClubmemberToEvent ClubmemberToEvent { get; set; }

        public ClubmemberToEventEditModel(IClubmemberEvent cerepo, IClubMemberRepository clubre, IEventRepository eventre)
        {
            _eventRepository = eventre;
            _clubrepo = clubre;
            _clubeventrepo = cerepo;
            List<ClubMember> members = _clubrepo.GetAllClubMembers();
            List<Event> Events = _eventRepository.GetAllEvents();
            ClubmemberNames = new SelectList(Events, "Id", "Name");
            EventNames = new SelectList(members, "Id", "Name");
        }


        public void OnGet(int id)
        {
            _clubeventrepo.GetClubmemberToEvent(id);
        }

        public IActionResult Onpost()
        {
            _clubeventrepo.EditClubmemberToEvent(ClubmemberToEvent);
            return RedirectToPage("ClubmemberToEvent");
        }

    }
}
