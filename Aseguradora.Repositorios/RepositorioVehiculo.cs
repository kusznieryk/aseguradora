using Aseguradora.Aplicacion;
namespace Aseguradora.Repositorios
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        private int _contador = 1;
        readonly string _nombreArch = "vehiculo.txt";
        public void AgregarVehiculo(Vehiculo vehiculo)//fachero
        {
            if (File.Exists(_nombreArch))
            {
                using var sr = new StreamReader(_nombreArch);
                while (!sr.EndOfStream)
                {
                    string? linea = sr.ReadLine() ?? "";
                    if (linea.Split('#')[1] == vehiculo.Dominio)
                        throw new Exception($"Ya existe un vehiculo con Dominio = {vehiculo.Dominio}");
                }
            }
            using var sw = new StreamWriter(_nombreArch, true);
            vehiculo.Id = _contador++;
            sw.WriteLine($"{vehiculo.Id}#{vehiculo.Dominio}#{vehiculo.Marca}#{vehiculo.Anio}#{vehiculo.TitularId}");

        }

        public void ModificarVehiculo(Vehiculo vehiculo)
        {
            using var sr = new StreamReader(_nombreArch);
            List<String> lineas = new List<string>();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine() ?? "";
                if ((linea.Split('#')[1]) != vehiculo.Dominio)
                {
                    lineas.Add(linea);
                }
                else
                {
                    vehiculo.Id = int.Parse(linea.Split('#')[0]);
                    lineas.Add($"{vehiculo.Id}#{vehiculo.Dominio}#{vehiculo.Marca}#{vehiculo.Anio}#{vehiculo.TitularId}");
                }
            }
            using var sw = new StreamWriter(_nombreArch);
            foreach (string item in lineas)
            {
                sw.WriteLine(item);
            }
        }

        public void EliminarVehiculo(int id) //si es el que quiero eliminar no lo agrego a la lista la cual reescribo despues
        {
            using var sr = new StreamReader(_nombreArch);
            List<String> lineas = new List<string>();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine() ?? "";
                if (int.Parse(linea.Split('#')[0]) != id)
                {
                    lineas.Add(linea);
                }
            }
            using var sw = new StreamWriter(_nombreArch);
            foreach (string item in lineas)
            {
                sw.WriteLine(item);
            }
        }

        public List<Vehiculo> ListarVehiculos()
        {
            var resultado = new List<Vehiculo>();
            using var sr = new StreamReader(_nombreArch);
            while (!sr.EndOfStream)
            {
                string[] campos = (sr.ReadLine() ?? "").Split('#');
                var vehiculo = new Vehiculo(campos[1], campos[2], int.Parse(campos[3]), int.Parse(campos[4]));
                vehiculo.Id = int.Parse(campos[0]);
                resultado.Add(vehiculo);
            }
            return resultado;
        }
    }
}