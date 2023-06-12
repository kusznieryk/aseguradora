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
    public Titular? Ejecutar(int id)
    {
        return _repo.ObtenerTitular(id);
    }
}