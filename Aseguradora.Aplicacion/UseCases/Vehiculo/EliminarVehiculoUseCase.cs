using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class EliminarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;

    public EliminarVehiculoUseCase(IRepositorioVehiculo repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.EliminarVehiculo(id);
    }
}