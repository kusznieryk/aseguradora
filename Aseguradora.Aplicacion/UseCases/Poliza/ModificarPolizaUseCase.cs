using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    private readonly ObtenerVehiculoUseCase _obtenerVehiculo;
    public ModificarPolizaUseCase(IRepositorioPoliza repo, IRepositorioVehiculo repoV)
    {
        this._repo = repo;
        _obtenerVehiculo = new ObtenerVehiculoUseCase(repoV);
    }
    public void Ejecutar(Poliza poliza)
    {
        if (_obtenerVehiculo.Ejecutar(poliza.VehiculoID) == null)
            throw new Exception("No existe ningun vehiculo con ese ID");
        _repo.ModificarPoliza(poliza);
    }
}
