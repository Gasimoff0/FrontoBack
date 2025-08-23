using System.Diagnostics;
using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class HomeController(AppDbContext appDbContext) : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            var homeVm = new HomeVm
            {
                Sliders = appDbContext.Sliders.ToList(),
                Clients = appDbContext.Clients.ToList()
            };
            
            return View(homeVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
