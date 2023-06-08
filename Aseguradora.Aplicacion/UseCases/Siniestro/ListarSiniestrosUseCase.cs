namespace Aseguradora.Aplicacion
{
    public class ListarSiniestrosUseCase
    {
        private readonly IRepositorioSiniestro _repo;

        public ListarSiniestrosUseCase(IRepositorioSiniestro repo){
            this._repo = repo;
        }
        public List<Siniestro> Ejecutar(){
            return _repo.ListarSiniestros();
        }
    }
}