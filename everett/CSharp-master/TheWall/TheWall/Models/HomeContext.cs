using Microsoft.EntityFrameworkCore;
 
namespace TheWall.Models
{
    public class HomeContext : DbContext
    {

        public HomeContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Message> Messages {get;set;}
        public DbSet<Comment> Comments {get;set;}
        public DbSet<Like> Likes {get;set;}
    }
}