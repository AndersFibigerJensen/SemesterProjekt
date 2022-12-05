using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boatmodel
{
    public class AddCrewmemberModel : PageModel
    {
        IBoatRepository _boatRepository;

        public ClubMember Clubmember { get; set; }

        public AddCrewmemberModel(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
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
            //_boatRepository.addCrewmembertoBoats()
            //return RedirectToPage("Crewlist");
            return Page();
        }
    }
}
