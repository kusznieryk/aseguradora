namespace Aseguradora.Aplicacion
{
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
}