using Microsoft.EntityFrameworkCore;
 
namespace e_Commerce.Models
{
    public class HomeContext : DbContext
    {

        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public DbSet<Order> Orders {get;set;}
    }
}