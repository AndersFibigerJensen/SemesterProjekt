using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.Eventmodel
{
    public class BoatToEventModel : PageModel
    {
        private IEventRepository eventRepository;
        private IBoatRepository boatRepository;
        private IEventBoatRepository eventBoatRepository;
        
        [BindProperty]
        public List<int> BoatIDs { get; set; }

        public BoatToEventModel(IEventRepository eventRepo, IBoatRepository boatRepo, IEventBoatRepository eventBoatRepo)
        {
            eventRepository = eventRepo;
            boatRepository = boatRepo;
            eventBoatRepository = eventBoatRepo;
        }


        public void OnGet(int id)
        {
            BoatIDs = eventBoatRepository.GetAllBoatsToEventIds(id);

        }
    }
}
