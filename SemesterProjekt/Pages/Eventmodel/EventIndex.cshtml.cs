using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class EventIndexModel : PageModel
    {
        private IEventRepository _eventrepo;

        public List<Event> Events { get; set; }

        public EventIndexModel(IEventRepository eventrepo)
        {
            _eventrepo = eventrepo;
        }

        public void OnGet()
        {
            Events=_eventrepo.GetAllEvents();
        }
    }
}
