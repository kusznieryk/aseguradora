using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Repositorios;
public class AseguradoraContext : DbContext
{
#nullable disable
    public DbSet<Poliza> Polizas { get; set; }
    public DbSet<Titular> Titulares { get; set; }

    public DbSet<Vehiculo> Vehiculos { get; set; }

    public DbSet<Siniestro> Siniestros { get; set; }

    public DbSet<Tercero> Terceros { get; set; }
#nullable enable
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
     #region Required
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Poliza>()
            .Property(p => p.Cobertura)
            .HasConversion(
                v => v.ToString(),
                v => (Cobertura)Enum.Parse(typeof(Cobertura), v));
    }
    #endregion
}