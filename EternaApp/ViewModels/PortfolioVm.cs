using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class PortfolioVm
    {
        public List<Category> Categories { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Client> Clients { get; set; }
    }
}
