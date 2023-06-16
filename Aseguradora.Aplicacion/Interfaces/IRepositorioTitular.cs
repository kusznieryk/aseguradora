using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioTitular
{
    void AgregarTitular(Titular titular);
    Titular? ObtenerTitular(int id);
    void ModificarTitular(Titular titular);
    void EliminarTitular(int id);
    List<Titular> ListarTitulares();
    List<Titular> ListarTitularesConSusVehiculos();
}