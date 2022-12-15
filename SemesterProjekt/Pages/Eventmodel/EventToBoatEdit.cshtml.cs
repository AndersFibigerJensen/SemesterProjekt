using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class EventToBoatEditModel : PageModel
    {
        private IEventRepository eventRepository;
        private IBoatRepository boatRepository;
        private IEventBoatRepository eventBoatRepository;

        [BindProperty]
        public BoatToEvent BoatToEvent { get; set; }

        public EventToBoatEditModel(IEventRepository eventRepo, IBoatRepository boatRepo, IEventBoatRepository eventBoatRepo)
        {
            eventRepository = eventRepo;
            boatRepository = boatRepo;
            eventBoatRepository = eventBoatRepo;
        }


        public void OnGet(int id)
        {
            BoatToEvent=eventBoatRepository.GetBoatToEvent(id);
        }

        public IActionResult Onpost()
        {
            eventBoatRepository.EditEventTOBoat(BoatToEvent);
            return RedirectToAction("BoatToEvent");
        }
    }
}
