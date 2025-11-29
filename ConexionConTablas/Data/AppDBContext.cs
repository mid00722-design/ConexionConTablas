namespace ConexionConTablas.Data
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using ConexionConTablas.Models;
   


    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Genero> Generos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>()
                .HasOne(g => g.Cliente)
                .WithMany()
                .HasForeignKey(g => g.Idcliente)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
