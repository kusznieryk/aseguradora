namespace Aseguradora.Aplicacion.Entidades;

public class Siniestro
{
    public int Id { get; set; } = -1;
    public int IdPoliza { get; set; }
    public DateTime FechaIngreso { get; set; } = DateTime.Now;
    public DateTime FechaOcurrencia { get; set; }
    public string Direccion { get; set; } = "";
    public string Descripcion { get; set; } = "";

    public Siniestro(int idPoliza, DateTime fechaOcurrencia, string direccion, string descripcion)
    {
        IdPoliza = idPoliza;
        FechaOcurrencia = fechaOcurrencia;
        Direccion = direccion;
        Descripcion = descripcion;
    }

}