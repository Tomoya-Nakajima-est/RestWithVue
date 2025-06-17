using Microsoft.EntityFrameworkCore;
using RESTwithVue.Models;

namespace RESTwithVue.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){ }
        public DbSet<Player> Players { get; set; }
        
    }
}
