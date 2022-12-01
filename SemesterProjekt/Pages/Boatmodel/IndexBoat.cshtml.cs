using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boatmodel
{
    public class IndexBoatModel : PageModel
    {
        private IBoatRepository boRepo;

        [BindProperty]
        public string FilterCriteria { get; set; }

        public List<Boat> Boats { get; set; }

        public IndexBoatModel(IBoatRepository boatRepo)
        {
            boRepo = boatRepo;
        }

        public void OnGet()
        {
            Boats = boRepo.GetAllBoats();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Boats = boRepo.FilterBoats(FilterCriteria);
            else
                Boats = boRepo.GetAllBoats();
        }


    }
}
