using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Repositorios;
public class RepositorioPoliza : IRepositorioPoliza
{

    public void AgregarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            //si falla mirar aca p.Cobertura==poliza.Cobertura
            //no permitimos agregar polizas del pasado
            bool existe = context.Polizas.FirstOrDefault((p => p.VehiculoID == poliza.VehiculoID && (poliza.FechaInicio <= p.FechaFin))) != null;
            if (existe)
                throw new Exception("Ya existe una Poliza con ese vehiculo id en ese rango de tiempo");
            context.Add(poliza);
            context.SaveChanges();
        }
    }

    public void ModificarPoliza(Poliza poliza)
    {
        using (var context = new AseguradoraContext())
        {
            var polizaViejo = context.Polizas.FirstOrDefault(p => p.Id == poliza.Id);
            if (polizaViejo != null)
            {
                polizaViejo.VehiculoID = poliza.VehiculoID;
                polizaViejo.ValorAsegurado = poliza.ValorAsegurado;
                polizaViejo.Franquicia = poliza.Franquicia;
                polizaViejo.Cobertura = poliza.Cobertura;
                polizaViejo.FechaInicio = poliza.FechaInicio;
                polizaViejo.FechaFin = poliza.FechaFin;
                context.SaveChanges();
            }
        }
    }

    public void EliminarPoliza(int id)
    {
        using (var context = new AseguradoraContext())
        {
            var poliza = context.Polizas.FirstOrDefault(v => v.Id == id);
            if (poliza != null)
            {
                context.Remove(poliza);
                context.SaveChanges();
            }
        }
    }

    public List<Poliza> ListarPolizas()
    {
        using (var context = new AseguradoraContext())
        {
            return context.Polizas.ToList();
        }
    }
}