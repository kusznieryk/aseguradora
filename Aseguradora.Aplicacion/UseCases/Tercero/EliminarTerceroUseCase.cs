using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class EliminarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;

    public EliminarTerceroUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        _repo.EliminarTercero(id);
    }
}