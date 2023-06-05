namespace Aseguradora.Aplicacion
{
    public class Titular : Persona
    {
        public string Direccion { get; set; } = "";
        public string Email { get; set; } = "";
        //public List<Vehiculo> ListaVehiculos { get; private set; } = new List<Vehiculo>();

        public Titular(int dni, string ap, string nom, string tel) : base(dni, ap, nom, tel) { }

        public override string ToString()
        {
            return base.ToString() + $" {Direccion} {Telefono} {Email}";
        }

    }
}