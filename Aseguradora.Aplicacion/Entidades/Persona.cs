namespace Aseguradora.Aplicacion.Entidades;
abstract public class Persona
{
    public int Dni { get; set; }
    public string Apellido { get; set; }

    public string Nombre { get; set; }

    public string Telefono { get; set; } = "";

    public int Id { get; set; } 

    public Persona(int dni, string ap, string nom, string telefono)
    {
        this.Dni = dni;
        this.Apellido = ap;
        this.Nombre = nom;
        this.Telefono = telefono;
    }
    public override string ToString()
    {
        return $"{Id}: {Dni} {Apellido}, {Nombre}";
    }
}
