using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Model;
using SemesterProjekt.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace SemesterProjekt.Pages.Clubmember
{
    public class AddMemberModel : PageModel
    {
        private IClubMemberRepository repo;
        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public IFormFile MemberImage { get; set; }

        [BindProperty]
        public ClubMember ClubMember { get; set; }

        public AddMemberModel(IClubMemberRepository clubMemberRepository, IWebHostEnvironment webHost)
        {
            repo = clubMemberRepository;
            webHost = webHostEnvironment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (MemberImage != null)
            {
                if (ClubMember.MemberImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "Images/ClubmemberImages", ClubMember.MemberImage);
                    System.IO.File.Delete(filePath);
                }

                ClubMember.MemberImage = ProcessUploadedFile();
            }
            repo.AddClubMember(ClubMember);
            return RedirectToPage("Index");

        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (MemberImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images/ClubmemberImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + MemberImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MemberImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
