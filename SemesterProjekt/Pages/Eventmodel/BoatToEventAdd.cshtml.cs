using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class BoatToEventAddModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IBoatRepository _boatRepository;
        private IEventBoatRepository _eventBoatRepository;

        public SelectList BoatNames { get; set; }

        public SelectList EventNames { get; set; }

        [BindProperty]
        public BoatToEvent BoatToevent { get; set; }

        public BoatToEventAddModel(IEventBoatRepository eventboatrepo,IBoatRepository boatrepo,IEventRepository eventrepo)
        {
            _eventRepository=eventrepo;
            _boatRepository = boatrepo;
            _eventBoatRepository = eventboatrepo;
            List<Boat> boatlist = _boatRepository.GetAllBoats();
            List<Event> events = _eventRepository.GetAllEvents();
            BoatNames = new SelectList(boatlist, "Id", "Name");
            EventNames = new SelectList(events, "Id", "Name");
        }

        public void OnGet()
        {

        }

        public IActionResult Onpost()
        {
            _eventBoatRepository.AddEventToBoat(BoatToevent);
            return Page();
        }
    }
}
