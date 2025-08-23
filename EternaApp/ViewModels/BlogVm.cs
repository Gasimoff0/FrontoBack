using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> RecentPosts { get; set; }
        public List<Category> Categories { get; set; }

    }
}
