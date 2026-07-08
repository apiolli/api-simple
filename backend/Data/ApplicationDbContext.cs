using api_simple.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_simple.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> Personas {  get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(p => p.Matricula).IsRequired().HasMaxLength(10);
                entity.Property(p => p.Nombres).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Apellidos).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Carrera).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Mascota>(entity =>
            {
                entity.Property(p => p.Edad).IsRequired();
                entity.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Raza).IsRequired().HasMaxLength(100);
            });
        }

    }
}
