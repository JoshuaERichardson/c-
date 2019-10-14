

using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
    }
}