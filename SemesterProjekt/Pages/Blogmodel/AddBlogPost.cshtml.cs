using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Blogmodel
{
    public class AddBlogPostModel : PageModel
    {
        private IBlogRepository blogRepository;
        [BindProperty]
        public BlogPost Post { get; set; }
        public AddBlogPostModel(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            blogRepository.AddBlogPost(Post);
            return RedirectToPage("IndexBlog");
        }
    }
}
