using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Clubmember
{
    public class EditMemberModel : PageModel
    {
        private IClubMemberRepository memberRepo;
        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public ClubMember ClubMember { get; set; }
        [BindProperty]
        public IFormFile Photo { get; set; }

        public EditMemberModel(IClubMemberRepository memberRepository, IWebHostEnvironment webHost)
        {
            this.memberRepo = memberRepository;
            webHostEnvironment = webHost;
        }

        public void OnGet(int id)
        {
            ClubMember = memberRepo.GetClubMember(id);
        }

        public IActionResult Onpost()
        {
            if (Photo != null)
            {
                if (ClubMember.MemberImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "Images/ClubmemberImages", ClubMember.MemberImage);
                    System.IO.File.Delete(filePath);
                }

                ClubMember.MemberImage = ProcessUploadedFile();
            }
            memberRepo.EditClubMember(ClubMember);
            return RedirectToPage("Index");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/ClubmemberImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
