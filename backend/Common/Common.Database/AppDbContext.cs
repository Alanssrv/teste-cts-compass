using Common.Entity;
using Microsoft.EntityFrameworkCore;

namespace Common.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionString = Environment.GetEnvironmentVariable("CTSCompassConnectionString");
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Environment connection string not provide");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().Property(p => p.Id);
        }

    }
}
