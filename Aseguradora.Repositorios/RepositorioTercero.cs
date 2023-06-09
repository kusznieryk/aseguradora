using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Repositorios;
public class RepositorioTercero : IRepositorioTercero
{

    public void AgregarTercero(Tercero tercero)
    {
        using (var context = new AseguradoraContext())
        {
            bool existe = context.Terceros.FirstOrDefault(t => t.Dni == tercero.Dni && t.IdSiniestro == tercero.IdSiniestro) != null;
            if (!existe)
            {
                context.Terceros.Add(tercero);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Ya existe un Tercero con ese DNI involucrado en ese siniestro");
            }
        }
    }

    public void ModificarTercero(Tercero tercero)
    {
        using (var context = new AseguradoraContext())
        {
            var terceroViejo = context.Terceros.FirstOrDefault(t => t.Dni == tercero.Dni && t.IdSiniestro == tercero.IdSiniestro);
            if (terceroViejo != null)
            {
                terceroViejo.Apellido = tercero.Apellido;
                terceroViejo.Nombre = tercero.Nombre;
                terceroViejo.NombreAseguradora = tercero.NombreAseguradora;
                terceroViejo.Telefono = tercero.Telefono;
                context.SaveChanges();
            }
        }
    }

    public void EliminarTercero(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var tercero = context.Terceros.FirstOrDefault(v => v.Id == id);
            if (tercero != null)
            {
                context.Remove(tercero);
                context.SaveChanges();
            }
        }
    }

    public List<Tercero> ListarTerceros()
    {
        using (var context = new AseguradoraContext())
        {
            return context.Terceros.ToList();
        }
    }
}