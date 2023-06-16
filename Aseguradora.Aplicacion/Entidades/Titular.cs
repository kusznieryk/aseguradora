namespace Aseguradora.Aplicacion.Entidades;
public class Titular : Persona
{
    public string Direccion { get; set; } = "";
    public string Email { get; set; } = "";
    public List<Vehiculo> Vehiculos { get; private set; } = new List<Vehiculo>();

    public Titular(int dni, string apellido, string nombre, string telefono) : base(dni, apellido, nombre, telefono) { }

    public override string ToString()
    {
        return base.ToString() + $" {Direccion} {Telefono} {Email}";
    }

}
