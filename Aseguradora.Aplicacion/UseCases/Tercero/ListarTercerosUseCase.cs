namespace Aseguradora.Aplicacion
{
    public class ListarTercerosUseCase
    {
        private readonly IRepositorioTercero _repo;

        public ListarTercerosUseCase(IRepositorioTercero repo){
            this._repo = repo;
        }
        public List<Tercero> Ejecutar(){
            return _repo.ListarTerceros();
        }
    }
}