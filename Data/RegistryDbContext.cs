using Microsoft.EntityFrameworkCore;

namespace MicrochipRegistry.Models
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Microchip> Microchips { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example: Make Microchip.Code a unique index
            modelBuilder.Entity<Microchip>()
                .HasIndex(m => m.Code)
                .IsUnique();
        }
    }
}
