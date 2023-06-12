using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerPolizaUseCase
{
    private readonly IRepositorioPoliza _repo;

    public ObtenerPolizaUseCase(IRepositorioPoliza repo)
    {
        this._repo = repo;
    }
    public Poliza? Ejecutar(int id)
    {
        return _repo.ObtenerPoliza(id);
    }
}