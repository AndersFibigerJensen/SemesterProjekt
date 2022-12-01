using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boat
{
    public class IndexBoatModel : PageModel
    {
        private IBoatRepository boatrepo;

        //public Boat boat { get; set; }
        public Boat Boat { get; set; }



        public void OnGet()
        {
        }
    }
}
