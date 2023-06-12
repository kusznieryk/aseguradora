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
    public void Ejecutar(int id)
    {
        //_repo.ObtenerVehiculo(id);
    }
}