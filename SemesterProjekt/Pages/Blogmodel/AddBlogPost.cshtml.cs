using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Blogmodel
{
    public class AddBlogPostModel : PageModel
    {
        private IWebHostEnvironment webHostEnvironment;
        private IBlogRepository blogRepository;

        [BindProperty]
        public IFormFile Photo { get; set; }
        [BindProperty]
        public BlogPost Post { get; set; }
        public AddBlogPostModel(IBlogRepository blogrepo, IWebHostEnvironment webHost)
        {
            blogRepository = blogrepo;
            webHostEnvironment = webHost;
            
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (Photo != null)
            {
                if (Post.PostImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/BlogImages", Post.PostImage);
                    System.IO.File.Delete(filePath);
                }

                Post.PostImage = ProcessUploadedFile();
            }
            blogRepository.AddBlogPost(Post);
            return RedirectToPage("IndexBlog");
        }
        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/BlogImages");
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
