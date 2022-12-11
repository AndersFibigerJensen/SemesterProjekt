using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.BoatToEvent
{
    public class BoatToEventIndexModel : PageModel
    {
        private IEventRepository eventRepository;
        private IBoatRepository boatRepository;


        public void OnGet()
        {
        }
    }
}
