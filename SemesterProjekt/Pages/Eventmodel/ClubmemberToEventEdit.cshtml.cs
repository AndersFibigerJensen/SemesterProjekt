using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class ClubmemberToEventEditModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IClubMemberRepository _clubrepo;
        private IClubmemberEvent _clubeventrepo;

        public ClubmemberToEvent ClubmemberToEvent { get; set; }

        public ClubmemberToEventEditModel(IClubmemberEvent cerepo, IClubMemberRepository clubre, IEventRepository eventre)
        {
            _eventRepository = eventre;
            _clubrepo = clubre;
            _clubeventrepo = cerepo;
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
