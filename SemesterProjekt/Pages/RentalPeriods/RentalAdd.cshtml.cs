using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalAddModel : PageModel
    {
        private IRentalSchedule schedule;
        private IBoatRepository _boatRepository;

        [BindProperty]
        public RentalPeriod Period { get; set; }

        public SelectList Boatnames;

        public RentalAddModel(IRentalSchedule rental, IBoatRepository boatrepo)
        {
            schedule = rental;
            _boatRepository=boatrepo;
            List<Boat> boatlist = _boatRepository.GetAllBoats();
            Boatnames = new SelectList(boatlist, "Id", "Name");
        }
        

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult Onpost()
        {
            schedule.AddRentalPeriod(Period);
            return RedirectToPage("RentalIndex");
        }
    }
}
