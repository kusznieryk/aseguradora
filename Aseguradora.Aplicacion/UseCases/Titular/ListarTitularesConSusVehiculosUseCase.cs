using Aseguradora.Aplicacion;
namespace Aseguradora.Aplicacion;
public class ListarTitularesConSusVehiculosUseCase
{
    private readonly ListarVehiculosUseCase _listarVehiculos;
    private readonly ListarTitularesUseCase _listarTitulares;
    public ListarTitularesConSusVehiculosUseCase( IRepositorioTitular repoT,IRepositorioVehiculo repoV)
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
                {
                    t.ListaVehiculos.Add(v);
                }
            }
        }
        return titulares;

    }
}