namespace Aseguradora.Repositorios;
using Microsoft.EntityFrameworkCore;
using Aseguradora.Aplicacion;
public class AseguradoraContext : DbContext
{
#nullable disable
    public DbSet<Poliza> Polizas { get; set; }
    public DbSet<Titular> Titulares { get; set; }

    public DbSet<Vehiculo> Vehiculos { get; set; }

    public DbSet<Siniestro> Siniestros { get; set; }

    public DbSet<Tercero> Terceros { get; set; }


#nullable disable
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}