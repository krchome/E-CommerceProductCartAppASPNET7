using ECommerceShoppingCartAppASPNET7.Models;
using Microsoft.EntityFrameworkCore;
namespace ECommerceShoppingCartAppASPNET7.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options) 
        { 
        }
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
