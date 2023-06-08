namespace Aseguradora.Aplicacion
{
    public class ModificarSiniestroUseCase
    {
        private readonly IRepositorioSiniestro _repo;

        public ModificarSiniestroUseCase(IRepositorioSiniestro repo){
            this._repo = repo;
        }
        public void Ejecutar(Siniestro siniestro){
            _repo.ModificarSiniestro(siniestro);
        }
    }
}