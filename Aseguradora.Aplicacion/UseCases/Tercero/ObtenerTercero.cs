using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerTerceroUseCase
{
    private readonly IRepositorioTercero _repo;

    public ObtenerTerceroUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        //_repo.ObtenerTercero(id);
    }
}