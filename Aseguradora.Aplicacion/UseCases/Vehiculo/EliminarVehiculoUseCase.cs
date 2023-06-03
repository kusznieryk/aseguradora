namespace Aseguradora.Aplicacion
{
    public class EliminarVehiculoUseCase
    {
        private readonly IRepositorioVehiculo _repo;

        public EliminarVehiculoUseCase(IRepositorioVehiculo repo){
            this._repo = repo;
        }
        public void Ejecutar(int id){
            _repo.EliminarVehiculo(id);
        }
    }
}