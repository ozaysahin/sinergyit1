using Microsoft.EntityFrameworkCore;
using sinergyit.Entities;

namespace sinergyit.Context
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=SinergyDb;Trusted_Connection=True;");
            }
        }

        public DbSet<Product> Products { get; set; }
    }
}
