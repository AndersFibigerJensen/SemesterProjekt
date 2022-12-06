using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class AddEventModel : PageModel
    {
        private IEventRepository _eventRepository;

        public Event Event { get; set; }

        public AddEventModel(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _eventRepository.AddEvent(Event);
            return RedirectToPage("EventIndex");
        }
    }
}
