using SemesterProjekt.Helpers;
using SemesterProjekt.Interfaces;
using SemesterProjekt.Model;

namespace SemesterProjekt.Services
{
    public class JsonBlogRepository : IBlogRepository
    {
        string filepath = @"Data\JsonBlogPosts.json";
        public void AddBlogPost(BlogPost post)
        {
            List<BlogPost> posts = GetAllPosts();
            List<int> PostIds = new List<int>();

            foreach (BlogPost po in posts)
            {
                PostIds.Add(po.PostId);
            }
            if (PostIds.Count != 0)
            {
                int start = PostIds.Max();
                post.PostId = start + 1;
            }
            else
            {
                post.PostId = 1;
            }
            posts.Add(post);
            JsonFileWriter.WritetoJsonBlogPosts(posts, filepath);
        }

        public void DeleteBlogPost(int postId)
        {
            BlogPost blogPostToDelete = GetBlogPost(postId);
            List<BlogPost> blogPosts = GetAllPosts();
            blogPosts.Remove(blogPostToDelete);
            JsonFileWriter.WritetoJsonBlogPosts(blogPosts, filepath);
        }

        public void EditBlogPost(BlogPost post)
        {
            if(post != null)
            {
                List<BlogPost> blogPosts = GetAllPosts();
                foreach(BlogPost b in blogPosts)
                {
                    if(b.PostId == post.PostId)
                    {
                        b.Title = post.Title;
                        b.Text = post.Text;
                    }
                }
                JsonFileWriter.WritetoJsonBlogPosts(blogPosts, filepath);
            }
        }

        public List<BlogPost> FilterBlogPosts(string filter)
        {
            List<BlogPost> PostList = new List<BlogPost>();
            foreach(var item in GetAllPosts())
                if(item.Title == filter)
                    PostList.Add(item);
            return PostList;
        }

        public List<BlogPost> GetAllPosts()
        {
            return JsonFileReader.ReadJsonBlogPost(filepath);
        }

        public BlogPost GetBlogPost(int postId)
        {
            List<BlogPost> blogPosts = GetAllPosts();
            foreach(BlogPost item in blogPosts)
                if(item.PostId == postId)
                    return item;
            return new BlogPost();
        }
    }
}
