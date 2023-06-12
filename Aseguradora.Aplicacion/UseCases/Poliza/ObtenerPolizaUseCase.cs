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
    public void Ejecutar(int id)
    {
        //_repo.ObtenerPoliza(id);
    }
}