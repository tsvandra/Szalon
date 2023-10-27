using Microsoft.EntityFrameworkCore;

namespace SzalonProjekt.Models
{
    public class SzalonDbContext : DbContext
    {
        public SzalonDbContext(DbContextOptions<SzalonDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
