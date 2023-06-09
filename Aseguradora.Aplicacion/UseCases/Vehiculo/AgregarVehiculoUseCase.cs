using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarVehiculoUseCase
{
    private readonly IRepositorioVehiculo _repo;
    private readonly ListarTitularesUseCase _listarTitulares;
    public AgregarVehiculoUseCase(IRepositorioVehiculo repo, IRepositorioTitular repoT)
    {
        this._repo = repo;
        this._listarTitulares = new ListarTitularesUseCase(repoT);
    }
    public void Ejecutar(Vehiculo vehiculo)
    {
        List<Titular> lista = _listarTitulares.Ejecutar();
        bool existe = false;
        foreach (Titular t in lista)
        {
            existe = existe || (t.Id == vehiculo.TitularId);
        }
        if (!existe)
            throw new Exception("No existe ningun Titular con ese ID");

        _repo.AgregarVehiculo(vehiculo);

    }
}