using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boatmodel
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository boatRepository;

        [BindProperty]
        public Boat Boat { get; set; }

        public EditBoatModel(IBoatRepository boatRepository)
        {
            this.boatRepository = boatRepository;
        }

        public void OnGet(int id)
        {
            Boat = boatRepository.GetBoat(id);
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            boatRepository.EditBoat(Boat);
            return RedirectToPage("IndexBoat");
        }
    }
}
