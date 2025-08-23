using EternaApp.Data;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class PortfolioController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new()
            {
                Categories = appDbContext.Categories.ToList(),
                Portfolios = appDbContext.Portfolios
                .Include(p => p.PortfolioImages)
                .Include(p => p.Category)
                .ToList(),
                Clients = appDbContext.Clients.ToList()
            };
            return View(portfolioVm);
        }

        public IActionResult Detail(int id)
        {
            var portfolio = appDbContext.Portfolios
                .Include(p => p.PortfolioImages)
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }
    }
}
