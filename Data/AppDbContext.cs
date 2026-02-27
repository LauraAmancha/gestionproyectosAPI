using Microsoft.EntityFrameworkCore;
using GestionProyectosAPI.Models;

namespace GestionProyectosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<ProyectoEmpleado> ProyectoEmpleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProyectoEmpleado>()
                .HasKey(pe => new { pe.ProyectoId, pe.EmpleadoId });
        }
    }
}