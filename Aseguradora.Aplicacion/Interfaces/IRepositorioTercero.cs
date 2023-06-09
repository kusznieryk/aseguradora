using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioTercero
{
    void AgregarTercero(Tercero tercero);
    void ModificarTercero(Tercero tercero);
    void EliminarTercero(int id);
    List<Tercero> ListarTerceros();
}
