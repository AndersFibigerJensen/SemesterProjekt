using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SemesterProjekt.Pages.Boats
{
    public class IndexModel : PageModel
    {
        public Model.Boat MyProperty { get; set; }

        public void OnGet()
        {
        }
    }
}
