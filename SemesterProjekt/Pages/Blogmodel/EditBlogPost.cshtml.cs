using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Blogmodel
{
    public class EditBlogPostModel : PageModel
    {
        private IBlogRepository blogRepository;

        [BindProperty]
        public BlogPost Post { get; set; }

        public EditBlogPostModel(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public void OnGet(int postId)
        {
            Post = blogRepository.GetBlogPost(postId);
        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            blogRepository.EditBlogPost(Post);
            return RedirectToPage("IndexBlog");

        }
        
    }
}
