using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Blogmodel
{
    public class DeleteBlogPostModel : PageModel
    {
        private IBlogRepository blogRepository;
        [BindProperty]
        public BlogPost Post { get; set; }
        public DeleteBlogPostModel(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public void OnGet(int postId)
        {
            Post = blogRepository.GetBlogPost(postId);
        }
        
        public IActionResult OnPost()
        {
            blogRepository.DeleteBlogPost(Post.PostId);
            return RedirectToPage("IndexBlog");
        }
    }
}
