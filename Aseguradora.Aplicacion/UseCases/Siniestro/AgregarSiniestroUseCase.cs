using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarSiniestroUseCase
{
    private readonly IRepositorioSiniestro _repo;
    private readonly ObtenerPolizaUseCase _obtenerPolizaUseCase;

    public AgregarSiniestroUseCase(IRepositorioSiniestro repo, IRepositorioPoliza repoP)
    {
        this._repo = repo;
        _obtenerPolizaUseCase = new ObtenerPolizaUseCase(repoP);
    }
    public void Ejecutar(Siniestro siniestro)
    {
        Poliza poliza = _obtenerPolizaUseCase.Ejecutar(siniestro.IdPoliza) ?? throw new Exception("La poliza no existe");
        if ((siniestro.FechaOcurrencia.CompareTo(poliza.FechaInicio) < 0) || (siniestro.FechaOcurrencia.CompareTo(poliza.FechaFin) > 0))
            throw new Exception("La fecha de ocurrencia del siniestro no esta en el rango de la poliza");
        _repo.AgregarSiniestro(siniestro);
    }
}