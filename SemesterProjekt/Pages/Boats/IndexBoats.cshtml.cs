using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;

namespace SemesterProjekt.Pages.Boats
{
    public class IndexBoatsModel : PageModel
    {

        private IBoatRepository boRepo;

        public void OnGet()
        {
        }

        public IndexBoatsModel(IBoatRepository boatRepo)
        {
            boRepo = boatRepo;
        }
    }
}
