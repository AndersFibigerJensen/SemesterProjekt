using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.RentalPeriods
{
    public class RentalIndexModel : PageModel
    {
        private IRentalSchedule _schedule;

        public List<RentalPeriod> Periods { get; set; }

        public RentalIndexModel(IRentalSchedule schedule)
        {
            _schedule=schedule;
        }

        public void OnGet()
        {
            Periods = _schedule.GetAllRentalPeriods();
        }

    }
}
