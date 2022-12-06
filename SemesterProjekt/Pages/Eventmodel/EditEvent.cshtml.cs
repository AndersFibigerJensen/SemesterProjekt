using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class EditEventModel : PageModel
    {
        private IEventRepository _eventRepository;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void OnGet()
        {
            Event = _eventRepository.GetEvent(Event.Id);
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventRepository.EditEvent(Event);
            return RedirectToPage("EventIndex");
        }
    }
}
