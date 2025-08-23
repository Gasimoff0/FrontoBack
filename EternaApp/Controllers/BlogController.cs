using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class BlogController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Index()
        {
            BlogVm blogVm = new BlogVm
            {
                Blogs = appDbContext.Blogs.ToList(),
                RecentPosts = appDbContext.Blogs.OrderByDescending(b => b.CreatedDate).ToList(),
                Categories = appDbContext.Categories.ToList()
            };

            return View(blogVm);
        }

        public IActionResult Detail(int id)
        {
            Blog blog = appDbContext.Blogs.FirstOrDefault(b => b.Id == id);

            if (blog == null) return NotFound();

            BlogDetailVm blogDetailVm = new BlogDetailVm
            {
                Blog = blog,
                RecentPosts = appDbContext.Blogs.OrderByDescending(b => b.Id).ToList(),
                Categories = appDbContext.Categories.ToList()
            };

            return View(blogDetailVm);
        }
    }
}
