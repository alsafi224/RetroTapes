using Microsoft.EntityFrameworkCore;

namespace RetroTapes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<RetroTapes.Models.Film> Films { get; set; }


     
    }
}