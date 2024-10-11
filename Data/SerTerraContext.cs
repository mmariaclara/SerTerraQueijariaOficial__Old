using Microsoft.EntityFrameworkCore;
using SerTerraQueijaria.Models;

namespace SerTerraQueijaria.Data
{
    public class SerTerraContext : DbContext
    {
        public SerTerraContext(DbContextOptions<SerTerraContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("tbClientes");
        }
    }
}
