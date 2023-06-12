using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ObtenerSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;

    public ObtenerSiniestroUseCase(IRepositorioSiniestro repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(int id)
    {
        //_repo.ObtenerSiniestro(id);
    }
}