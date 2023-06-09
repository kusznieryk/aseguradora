using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioVehiculo
{
    void AgregarVehiculo(Vehiculo vehiculo);
    void ModificarVehiculo(Vehiculo vehiculo);
    void EliminarVehiculo(int id);
    List<Vehiculo> ListarVehiculos();
}