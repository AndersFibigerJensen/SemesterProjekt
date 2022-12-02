using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalEditModel : PageModel
    {
        private IRentalSchedule _schedule;

        [BindProperty]
        public RentalPeriod RentalPeriod { get; set; }

        public RentalEditModel(IRentalSchedule schedule)
        {
            _schedule = schedule;
        }

        public void OnGet(int id)
        {
            RentalPeriod = _schedule.GetRentalPeriod(id);
        }

        public IActionResult OnPost()
        {
            _schedule.EditRentalPeriod(RentalPeriod);
            return RedirectToPage("Rentalindex");
        }
    }
}
