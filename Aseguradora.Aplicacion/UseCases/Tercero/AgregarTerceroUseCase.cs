using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarTerceroUseCase
{
    private readonly IRepositorioTercero _repo;
    private readonly ObtenerSiniestroUseCase _obtenerSiniestroUseCase;

    public AgregarTerceroUseCase(IRepositorioTercero repo, IRepositorioSiniestro repoS)
    {
        this._repo = repo;
        _obtenerSiniestroUseCase = new ObtenerSiniestroUseCase(repoS);
    }
    public void Ejecutar(Tercero tercero)
    {
        if(_obtenerSiniestroUseCase.Ejecutar(tercero.IdSiniestro)==null)
            throw new Exception("El siniestro no existe");
        _repo.AgregarTercero(tercero);
    }
}