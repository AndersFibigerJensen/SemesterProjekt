using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalAddModel : PageModel
    {
        private IRentalSchedule schedule;

        [BindProperty]
        public RentalPeriod Period { get; set; }

        public RentalAddModel(IRentalSchedule rental)
        {
            schedule = rental;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            schedule.AddRentalPeriod(Period);
            return RedirectToPage("Index");
        }
    }
}
