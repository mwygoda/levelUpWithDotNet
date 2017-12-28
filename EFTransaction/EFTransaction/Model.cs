using System.Data.Entity;

namespace EFTransaction
{
    public class PostsContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}