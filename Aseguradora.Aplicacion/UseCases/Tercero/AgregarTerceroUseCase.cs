using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;

    public AgregarTerceroUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Tercero tercero)
    {
        _repo.AgregarTercero(tercero);
    }
}