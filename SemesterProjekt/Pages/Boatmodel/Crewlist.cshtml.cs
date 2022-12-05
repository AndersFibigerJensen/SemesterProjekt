using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Boatmodel
{
    public class CrewlistModel : PageModel
    {
        private IBoatRepository _Boatrepo;
        

        //[BindProperty]
        //public Boat boat { get; set; }

        public List<ClubMember> Crewlist {get; set;}

        public CrewlistModel(IBoatRepository boatrepo)
        {
            _Boatrepo = boatrepo;
        }

        public void OnGet(int id)
        {
            Boat theBoat = _Boatrepo.GetBoat(id);
            Crewlist = theBoat.Crewlist;
        }
    }
}
