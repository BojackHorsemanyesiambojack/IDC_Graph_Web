using IDC_Web.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace IDC_Web.Shared.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<IProduct> product { get; set; }
    }
}
