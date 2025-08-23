using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class BlogDetailVm
    {
        public Blog Blog { get; set; }
        public List<Blog> RecentPosts { get; set; }
        public List<Category> Categories { get; set; }
    }
}
