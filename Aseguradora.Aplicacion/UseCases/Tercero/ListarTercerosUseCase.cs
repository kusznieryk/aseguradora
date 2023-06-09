using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ListarTercerosUseCase
{
    private readonly IRepositorioTercero _repo;

    public ListarTercerosUseCase(IRepositorioTercero repo)
    {
        this._repo = repo;
    }
    public List<Tercero> Ejecutar()
    {
        return _repo.ListarTerceros();
    }
}