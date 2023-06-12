using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;

    public ObtenerVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }
    public Vehiculo? Ejecutar(int id)
    {
        return _repo.ObtenerVehiculo(id);
    }
}