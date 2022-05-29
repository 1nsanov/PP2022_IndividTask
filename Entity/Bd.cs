using Microsoft.EntityFrameworkCore;

namespace Vitek
{
    public class Bd : DbContext
    {
        public Bd()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OL7HB4A;Database=OrdersTickets;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User>? Users { get; set; } = null!;
        public DbSet<Hotels>? Hotels { get; set; } = null!;
        public DbSet<Plain>? Plain { get; set; } = null!;

    }
}
