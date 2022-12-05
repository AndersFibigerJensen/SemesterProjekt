using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalDeleteModel : PageModel
    {
        private IRentalSchedule schedule;

        [BindProperty]
        public RentalPeriod Period { get; set; }

        public RentalDeleteModel(IRentalSchedule rental)
        {
            this.schedule = rental;
        }


        public void OnGet(int id)
        {
            Period = schedule.GetRentalPeriod(id);
        }

        public IActionResult Onpost()
        {
            schedule.RemoveRentalPeriod(Period.Id);
            return RedirectToPage("Rentalindex");
        }
    }
}
