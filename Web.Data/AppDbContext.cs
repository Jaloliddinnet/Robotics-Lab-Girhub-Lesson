using Microsoft.EntityFrameworkCore;

namespace WebApplicationGitHub
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        

    }
}
