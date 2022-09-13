using Microsoft.EntityFrameworkCore;
using Mini_Football.Models;

namespace Mini_Football.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Players> Players { get; set; }
        public DbSet<SLider> Sliders { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Gallery> Galeries { get; set; }
    }
}
