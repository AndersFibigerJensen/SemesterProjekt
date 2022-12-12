using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Pages.Blogmodel
{
    public class IndexBlogModel : PageModel
    {
        private IBlogRepository blRepo;
        [BindProperty]
        public string FilterCriteria { get; set; }

        public List<BlogPost> Posts { get; set; }

        public IndexBlogModel(IBlogRepository blogRepo)
        {
            blRepo = blogRepo;
        }
        public void OnGet()
        {
            Posts = blRepo.GetAllPosts();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Posts = blRepo.FilterBlogPosts(FilterCriteria);
            else
                Posts = blRepo.GetAllPosts();
        }
    }
}
