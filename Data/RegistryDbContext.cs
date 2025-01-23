using Microsoft.EntityFrameworkCore;

namespace NationalMicrochipRegistry.Models
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

            // Make Microchip.Code a unique index
            modelBuilder.Entity<Microchip>()
                .HasIndex(m => m.Code)
                .IsUnique();

            // Configure the Animal -> Microchip as 1-to-1 (if applicable)
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Microchip)
                .WithOne(m => m.Animal)
                .HasForeignKey<Animal>(a => a.MicrochipId);
        }
    }
}
