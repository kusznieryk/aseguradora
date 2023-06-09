using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarVehiculosUseCase
{
    private readonly IRepositorioVehiculo _repo;

    public ListarVehiculosUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }
    public List<Vehiculo> Ejecutar()
    {
        return _repo.ListarVehiculos();
    }
}