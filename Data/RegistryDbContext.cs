using Microsoft.EntityFrameworkCore;

namespace NationalMicrochipRegistry.Models
{
    /// <summary>
    /// Represents the database context for the National Microchip Registry.
    /// </summary>
    public class RegistryDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistryDbContext"/> class.
        /// </summary>
        /// <param name="options">The options to configure the context.</param>
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the collection of users in the database.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the collection of clinics in the database.
        /// </summary>
        public DbSet<Clinic> Clinics { get; set; }

        /// <summary>
        /// Gets or sets the collection of microchips in the database.
        /// </summary>
        public DbSet<Microchip> Microchips { get; set; }

        /// <summary>
        /// Gets or sets the collection of animals in the database.
        /// </summary>
        public DbSet<Animal> Animals { get; set; }

        /// <summary>
        /// Configures the model relationships and constraints.
        /// </summary>
        /// <param name="modelBuilder">The builder used to configure the model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Make Microchip.Code a unique index
            modelBuilder.Entity<Microchip>()
                .HasIndex(m => m.Code)
                .IsUnique();

            // Configure Animal to Microchip as one-to-one relationship
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Microchip)
                .WithOne(m => m.Animal)
                .HasForeignKey<Animal>(a => a.MicrochipId);
        }
    }
}
