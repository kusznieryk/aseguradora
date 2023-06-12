using Aseguradora.Aplicacion.Entidades;
namespace Aseguradora.Aplicacion.Interfaces;
public interface IRepositorioSiniestro
{
    void AgregarSiniestro(Siniestro siniestro);
    Siniestro? ObtenerSiniestro(int id);
    void ModificarSiniestro(Siniestro siniestro);
    void EliminarSiniestro(int id);
    List<Siniestro> ListarSiniestros();
}