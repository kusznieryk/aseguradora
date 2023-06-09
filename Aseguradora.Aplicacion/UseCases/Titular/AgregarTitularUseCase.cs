using Aseguradora.Aplicacion.Entidades;
using Aseguradora.Aplicacion.Interfaces;
namespace Aseguradora.Aplicacion.UseCases;
public class AgregarTitularUseCase
{
    private readonly IRepositorioTitular _repo;

    public AgregarTitularUseCase(IRepositorioTitular repo)
    {
        this._repo = repo;
    }
    public void Ejecutar(Titular titular)
    {
        _repo.AgregarTitular(titular);
    }
}