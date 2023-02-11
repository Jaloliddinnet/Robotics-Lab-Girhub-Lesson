using Microsoft.EntityFrameworkCore;
using Web.Data.Models;

namespace WebApplicationGitHub
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Meals> meals { get; set; }      
    }
}
