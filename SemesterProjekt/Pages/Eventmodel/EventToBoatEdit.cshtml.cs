using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class EventToBoatEditModel : PageModel
    {
        private IEventRepository _eventRepository;
        private IBoatRepository _boatRepository;
        private IEventBoatRepository _eventBoatRepository;

        public SelectList BoatNames { get; set; }

        public SelectList EventNames { get; set; }
        [BindProperty]
        public BoatToEvent BoatToEvent { get; set; }

        public EventToBoatEditModel(IEventRepository eventRepo, IBoatRepository boatRepo, IEventBoatRepository eventBoatRepo)
        {
            _eventRepository = eventRepo;
            _boatRepository = boatRepo;
            _eventBoatRepository = eventBoatRepo;
            List<Boat> boatlist = _boatRepository.GetAllBoats();
            List<Event> events = _eventRepository.GetAllEvents();
            BoatNames = new SelectList(boatlist, "Id", "Name");
            EventNames = new SelectList(events, "Id", "Name");
        }


        public void OnGet(int id)
        {
            BoatToEvent=_eventBoatRepository.GetBoatToEvent(id);
        }

        public IActionResult Onpost()
        {
            _eventBoatRepository.EditEventTOBoat(BoatToEvent);
            return RedirectToAction("BoatToEvent");
        }
    }
}
