using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options){}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Rolex", Description = "White and Gold", Category = "Accessories", Price = 200000, Quantity = 7 },
                new Product { Id = 2, Name = "Power Bank", Description = "Black, small, ortable", Category="Electronics", Price=7000, Quantity = 12 }

                );
        }
        //public DbSet<ProductManagement.Models.Category> Category { get; set; } = default!;
    }
}
