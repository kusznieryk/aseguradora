using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class ModificarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    private readonly ObtenerPolizaUseCase _obtenerPolizaUseCase;
    public ModificarSiniestroUseCase(IRepositorioSiniestro repo, IRepositorioPoliza repoP)
    {
        this._repo = repo;
        _obtenerPolizaUseCase = new ObtenerPolizaUseCase(repoP);
    }
    public void Ejecutar(Siniestro siniestro)
    {
        if(_obtenerPolizaUseCase.Ejecutar(siniestro.IdPoliza)==null)
            throw new Exception("La poliza no existe");
        _repo.ModificarSiniestro(siniestro);
    }
}