using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class AddEventModel : PageModel
    {
        private IEventRepository eventrepo;

        public Event Event { get; set; }

        public AddEventModel(IEventRepository eventrepo)
        {
            this.eventrepo = eventrepo;
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
            eventrepo.AddEvent(Event);
            return RedirectToPage("EventIndex");
        }
    }
}
