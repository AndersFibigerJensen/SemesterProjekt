using SemesterProjekt.Model;

namespace SemesterProjekt.Interfaces
{
    public interface IBlogRepository
    {
        List<BlogPost> GetAllPosts();
        BlogPost GetBlogPost(int postId);
        void AddBlogPost(BlogPost post);
        void EditBlogPost(BlogPost post);
        void DeleteBlogPost(int postId);
        List<BlogPost> FilterBlogPosts(string filter);
    }
}
