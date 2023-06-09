namespace Aseguradora.Aplicacion.Entidades;
public class Vehiculo
{
    public int Id { get; set; } = -1;
    public string Dominio { get; set; }
    public string Marca { get; set; }
    public int Anio { get; set; }
    public int TitularId { get; set; }
    public Vehiculo(string dominio, string marca, int anio, int titularId)
    {
        this.Dominio = dominio;
        this.Marca = marca;
        this.Anio = anio;
        this.TitularId = titularId;
    }
    public override string ToString()
    {
        return $"{Id}: {Dominio}, {Marca}, {Anio}, {TitularId}";
    }
}