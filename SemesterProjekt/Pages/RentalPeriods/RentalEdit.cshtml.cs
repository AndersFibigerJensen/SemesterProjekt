using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalEditModel : PageModel
    {
        private IRentalSchedule _schedule;
        private IBoatRepository _boatRepository;

        [BindProperty]
        public RentalPeriod Period { get; set; }

        public SelectList Boatnames;

        public RentalEditModel(IRentalSchedule schedule, IBoatRepository boatRepository)
        {
            _schedule = schedule;
            _boatRepository = boatRepository;
            List<Boat> boatlist = _boatRepository.GetAllBoats();
            Boatnames = new SelectList(boatlist, "Id", "Name");
        }

        public void OnGet(int id)
        {
            Period = _schedule.GetRentalPeriod(id);
            List<Boat> boatlist = _boatRepository.GetAllBoats();
            Boatnames = new SelectList(boatlist, "Id", "Name");
        }

        public IActionResult OnPost()
        {
            _schedule.EditRentalPeriod(Period);
            return RedirectToPage("Rentalindex");
        }
    }
}
