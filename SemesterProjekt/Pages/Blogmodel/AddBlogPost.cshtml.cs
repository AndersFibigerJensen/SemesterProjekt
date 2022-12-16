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
                if (BlogPost.PostImage != null)
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/BlogImages", BlogPost.PostImage);
                    System.IO.File.Delete(filePath);
                }

                 = ProcessUploadedFile();
            }
            if (!ModelState.IsValid)
                return Page();
            blogRepository.AddBlogPost(Post);
            return RedirectToPage("IndexBlog");
        }
    }
}
