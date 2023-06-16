using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    private readonly ObtenerTitularUseCase _obtenerTitular;


    public ModificarVehiculoUseCase(IRepositorioVehiculo repo, IRepositorioTitular repoT)
    {
        this._repo = repo;
        _obtenerTitular = new ObtenerTitularUseCase(repoT);
    }
    public void Ejecutar(Vehiculo vehiculo)
    {
        if (_obtenerTitular.Ejecutar(vehiculo.TitularId) == null)
            throw new Exception("No existe ningun titular con ese ID");
        _repo.ModificarVehiculo(vehiculo);
    }
}