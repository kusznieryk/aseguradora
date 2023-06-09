using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;
    private readonly ListarVehiculosUseCase _listarVehiculos;

    public AgregarPolizaUseCase(IRepositorioPoliza repo, IRepositorioVehiculo repoV)
    {
        this._repo = repo;
        _listarVehiculos = new ListarVehiculosUseCase(repoV);
    }
    public void Ejecutar(Poliza poliza)
    {
        List<Vehiculo> lista = _listarVehiculos.Ejecutar();
        bool existe = false;
        foreach (Vehiculo v in lista)
        {
            existe = existe || (v.Id == poliza.VehiculoID);
        }
        if (!existe)
            throw new Exception("No existe ningun vehiculo con ese ID");

        _repo.AgregarPoliza(poliza);
    }
}