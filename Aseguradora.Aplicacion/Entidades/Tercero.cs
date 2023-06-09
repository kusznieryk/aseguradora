namespace Aseguradora.Aplicacion.Entidades;

public class Tercero : Persona
{
    public String NombreAseguradora { get; set; }
    public int IdSiniestro { get; set; }

    public Tercero(string nombreAseguradora, int idSiniestro, int dni, string ap, string nom, string tel) : base(dni, ap, nom, tel)
    {
        NombreAseguradora = nombreAseguradora;
        IdSiniestro = idSiniestro;
    }
}