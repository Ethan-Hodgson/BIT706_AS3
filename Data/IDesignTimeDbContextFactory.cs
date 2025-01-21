using MicrochipRegistry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace National_Microchip_Registry.Data
{
    public class DesignTimeRegistryDbContextFactory
        : IDesignTimeDbContextFactory<RegistryDbContext>
    {
        public RegistryDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RegistryDbContext>();

            // Example SQLite connection string - "Data Source=" + a file name
            var connectionString = "Data Source=Registry.db";

            builder.UseSqlite(connectionString);

            return new RegistryDbContext(builder.Options);
        }
    }
}
