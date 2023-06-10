namespace Aseguradora.Aplicacion.Entidades;

public class Tercero : Persona
{
    public String NombreAseguradora { get; set; }
    public int IdSiniestro { get; set; }

    public Tercero(string nombreAseguradora, int idSiniestro, int dni, string apellido, string nombre, string telefono) : base(dni, apellido, nombre, telefono)
    {
        NombreAseguradora = nombreAseguradora;
        IdSiniestro = idSiniestro;
    }
}