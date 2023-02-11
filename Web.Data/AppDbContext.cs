using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Car> cars { get; set; }
       public DbSet<Futbol> futbolist { get; set; }
        public DbSet<Kompyuterlar> Kompyuterlars { get; set; }
        public DbSet<University> universities { get; set; }
        public DbSet<Meals> meals { get; set; }      
    }
}
