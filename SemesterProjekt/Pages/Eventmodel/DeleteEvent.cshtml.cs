using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class DeleteEventModel : PageModel
    {
        private IEventRepository _eventRepository;

        [BindProperty]
        public Event Event { get; set; }

        public DeleteEventModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void OnGet(int id)
        {
            Event = _eventRepository.GetEvent(id);
        }

        public IActionResult Onpost()
        {
            _eventRepository.RemoveEvent(Event.Id);
            return RedirectToPage("EventIndex");
        }
    }
}
