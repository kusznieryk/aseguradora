using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerTitularUseCase
{
    private readonly IRepositorioTitular _repo;

    public ObtenerTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        //_repo.ObtenerTitular(id);
    }
}