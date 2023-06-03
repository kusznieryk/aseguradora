namespace Aseguradora.Aplicacion
{
    abstract public class Persona
    {
        public int Dni { get; set; }
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }= "";

        public int Id { get; set; } = -1;

        public Persona(int dni, string ap, string nom)
        {
            this.Dni = dni;
            this.Apellido = ap;
            this.Nombre = nom;
        }
        public override string ToString()
        {
            return $"{Id}: {Dni} {Apellido}, {Nombre}";
        }
    }
}