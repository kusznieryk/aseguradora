using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Repositorios;
public class RepositorioSiniestro : IRepositorioSiniestro
{

    public void AgregarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {
            context.Add(siniestro);
            context.SaveChanges();
        }
    }

    public void ModificarSiniestro(Siniestro siniestro)
    {
        using (var context = new AseguradoraContext())
        {
            var siniestroViejo = context.Siniestros.FirstOrDefault(s => s.Id == siniestro.Id);
            if (siniestroViejo != null)
            {
                siniestroViejo.Descripcion = siniestro.Descripcion;
                siniestroViejo.Direccion = siniestro.Direccion;
                siniestroViejo.FechaIngreso = siniestro.FechaIngreso;
                siniestroViejo.FechaOcurrencia = siniestro.FechaOcurrencia;
                siniestroViejo.IdPoliza = siniestro.IdPoliza;
                context.SaveChanges();
            }
        }
    }

    public void EliminarSiniestro(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var siniestro = context.Siniestros.FirstOrDefault(v => v.Id == id);
            if (siniestro != null)
            {
                context.Remove(siniestro);
                context.SaveChanges();
            }
        }
    }

    public List<Siniestro> ListarSiniestros()
    {
        using (var context = new AseguradoraContext())
        {
            return context.Siniestros.ToList();
        }
    }
}