using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class BoatToeventDeleteModel : PageModel
    {
        private IEventRepository eventRepository;
        private IBoatRepository boatRepository;
        private IEventBoatRepository eventBoatRepository;

        [BindProperty]
        public BoatToEvent BoatToEvent { get; set; }

        public BoatToeventDeleteModel(IEventRepository eventRepository, IBoatRepository boatRepository, IEventBoatRepository eventBoatRepository)
        {
            this.eventRepository = eventRepository;
            this.boatRepository = boatRepository;
            this.eventBoatRepository = eventBoatRepository;
        }


        public void OnGet(int id)
        {
            BoatToEvent = eventBoatRepository.GetBoatToEvent(id);
        }

        public IActionResult Onpost()
        {
            eventBoatRepository.RemoveEventToBoat(BoatToEvent.BookingID);
            return RedirectToPage("BoatToEvent");

        }
    }
}
