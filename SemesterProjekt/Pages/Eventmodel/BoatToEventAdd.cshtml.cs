using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class BoatToEventAddModel : PageModel
    {
        private IEventRepository eventRepository;
        private IBoatRepository boatRepository;
        private IEventBoatRepository eventBoatRepository;

        public SelectList BoatNames { get; set; }

        public SelectList EventNames { get; set; }

        [BindProperty]
        public BoatToEvent BoatToevent { get; set; }

        public BoatToEventAddModel(IEventBoatRepository eventboatrepo,IBoatRepository boatrepo,IEventRepository eventrepo)
        {
            eventRepository=eventrepo;
            boatRepository = boatrepo;
            eventBoatRepository = eventboatrepo;
        }

        public void OnGet()
        {

        }

        public IActionResult Onpost()
        {
            eventBoatRepository.AddEventToBoat(BoatToevent);
            return Page();
        }
    }
}
