using Microsoft.EntityFrameworkCore;
using ShopApplication.Models;
namespace ShopApplication.AppdbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.Configuration.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

  
}
