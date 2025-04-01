using Common.Entity;
using Microsoft.EntityFrameworkCore;

namespace Common.Database
{
    /// <summary>
    /// Contexto de conexão com banco de dados da aplicação
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Conjunto de dados da entidade Produto
        /// </summary>
        public DbSet<Produto> Produtos { get; set; }

        /// <summary>
        /// Configurações do contexto e conexão com banco de dados SQL Server
        /// </summary>
        /// <param name="optionsBuilder">Construtor de opções do contexto</param>
        /// <exception cref="Exception">Lançada quando a string de conexão não é fornecida</exception>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? connectionString = Environment.GetEnvironmentVariable("CTSCompassConnectionString");
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Environment connection string not provide");

            optionsBuilder.UseSqlServer(connectionString);
        }

        /// <summary>
        /// Configurações do modelo de entidades
        /// </summary>
        /// <param name="modelBuilder">Construtor do modelo de entidades</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().Property(p => p.Id);
        }
    }
}
