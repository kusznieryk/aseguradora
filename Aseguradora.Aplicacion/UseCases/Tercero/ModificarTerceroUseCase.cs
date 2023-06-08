namespace Aseguradora.Aplicacion
{
    public class ModificarTerceroUseCase
    {
        private readonly IRepositorioTercero _repo;

        public ModificarTerceroUseCase(IRepositorioTercero repo){
            this._repo = repo;
        }
        public void Ejecutar(Tercero tercero){
            _repo.ModificarTercero(tercero);
        }
    }
}