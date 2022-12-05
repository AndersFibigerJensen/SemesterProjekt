using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boatmodel
{
    public class AddBoatModel : PageModel
    {
        private IBoatRepository boatRepository;

        [BindProperty]
        public Boat Boat { get; set; }

        public AddBoatModel(IBoatRepository boatRepository)
        {
            this.boatRepository = boatRepository;

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            boatRepository.AddBoat(Boat);
            return RedirectToPage("IndexBoat");

        }
    }
}
