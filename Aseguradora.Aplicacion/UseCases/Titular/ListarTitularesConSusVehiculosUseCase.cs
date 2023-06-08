using Aseguradora.Aplicacion;
namespace Aseguradora.Aplicacion;
class ListarTitularesConSusVehiculosUseCase
{
    //modificar este use case con el metodo que creemos en el repositorio


    private readonly ListarVehiculosUseCase _listarVehiculos;
    private readonly ListarTitularesUseCase _listarTitulares;
    public ListarTitularesConSusVehiculosUseCase(IRepositorioVehiculo repoV, IRepositorioTitular repoT)
    {
        _listarVehiculos = new ListarVehiculosUseCase(repoV);
        _listarTitulares = new ListarTitularesUseCase(repoT);
    }
    public List<Titular> Ejecutar()
    {
        List<Vehiculo> vehiculos = _listarVehiculos.Ejecutar();
        List<Titular> titulares = _listarTitulares.Ejecutar();
        foreach (Titular t in titulares)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.TitularId == t.Id) 
                    t.ListaVehiculos.Add(v);
            }
        }
        return titulares;

    }
}