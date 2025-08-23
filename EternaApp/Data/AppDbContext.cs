using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Slider> Sliders { get; set; }
        public DbSet<Models.Portfolio> Portfolios { get; set; }
        public DbSet<Models.PortfolioImages> PortfolioImages { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Client> Clients { get; set; }
        public DbSet<Models.Blog> Blogs { get; set; }
    }
}
