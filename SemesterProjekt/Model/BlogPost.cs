namespace SemesterProjekt.Model
{
    public class BlogPost
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PostImage { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                BlogPost other = (BlogPost)obj;
                if (other.PostId == PostId)
                    return true;
                else
                    return false;
            }
        }
    }
}
