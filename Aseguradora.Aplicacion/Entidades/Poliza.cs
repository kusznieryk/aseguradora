namespace Aseguradora.Aplicacion.Entidades;
public class Poliza
{
    public int Id { get; set; }
    public int VehiculoID { get; set; }
    public decimal ValorAsegurado { get; set; }
    public decimal Franquicia { get; set; }
    public Cobertura Cobertura { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public Poliza(int vehiculoID, decimal valorAsegurado, decimal franquicia, Cobertura cobertura, DateTime fechaInicio, DateTime fechaFin)
    {
        // TCobertura aux = new TCobertura(); DUDOSO
        // Enum.TryParse(cobertura, out aux);
        this.VehiculoID = vehiculoID;
        this.ValorAsegurado = valorAsegurado;
        this.Franquicia = franquicia;
        // this.Cobertura = aux;
        this.Cobertura = cobertura;
        this.FechaInicio = fechaInicio;
        this.FechaFin = fechaFin;
    }
    public override string ToString()
    {
        return $"{Id}: {VehiculoID}, {ValorAsegurado}, {Franquicia}, {Cobertura}, {FechaInicio:yyyy/MM/dd}, {FechaFin:yyyy/MM/dd}";
    }

}