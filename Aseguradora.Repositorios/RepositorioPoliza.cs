using Aseguradora.Aplicacion;
namespace Aseguradora.Repositorios
{
    public class RepositorioPoliza:IRepositorioPoliza
    {
        private int _contador = 1;
        readonly string _nombreArch = "poliza.txt";
        public void AgregarPoliza(Poliza poliza)//fachero
        {
            if (File.Exists(_nombreArch))
            {
                using var sr = new StreamReader(_nombreArch);
                while (!sr.EndOfStream)
                {
                    string? linea = sr.ReadLine() ?? "";
                    if (int.Parse(linea.Split('#')[1]) == poliza.VehiculoID){
                        Cobertura aux = new Cobertura();
                        Enum.TryParse(linea.Split('#')[4], out aux);
                        if(aux==poliza.Cobertura)
                            throw new Exception($"Ya existe un poliza del vehiculo = {poliza.VehiculoID} con cobertura del tipo {poliza.Cobertura}");
                    }
                }
            }
            using var sw = new StreamWriter(_nombreArch, true);
            poliza.Id = _contador++;
            sw.WriteLine($"{poliza.Id}#{poliza.VehiculoID}#{poliza.ValorAsegurado}#{poliza.Franquicia}#{poliza.Cobertura}#{poliza.FechaInicio}#{poliza.FechaFin}");

        }

        public void ModificarPoliza(Poliza poliza)
        {
            using var sr = new StreamReader(_nombreArch);
            List<String> lineas = new List<string>();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine() ?? "";
                if (int.Parse(linea.Split('#')[1]) != poliza.VehiculoID)
                {
                    lineas.Add(linea);
                }
                else
                {
                    poliza.Id = int.Parse(linea.Split('#')[0]);
                    lineas.Add($"{poliza.Id}#{poliza.VehiculoID}#{poliza.ValorAsegurado}#{poliza.Franquicia}#{poliza.Cobertura}#{poliza.FechaInicio}#{poliza.FechaFin}");
                }
            }
            using var sw = new StreamWriter(_nombreArch);
            foreach (string item in lineas)
            {
                sw.WriteLine(item);
            }
        }

        public void EliminarPoliza(int id) //si es el que quiero eliminar no lo agrego a la lista la cual reescribo despues
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

        public List<Poliza> ListarPolizas()
        {
            var resultado = new List<Poliza>();
            using var sr = new StreamReader(_nombreArch);
            while (!sr.EndOfStream)
            {
                string[] campos = (sr.ReadLine() ?? "").Split('#');
                var poliza = new Poliza(int.Parse(campos[1]), decimal.Parse(campos[2]), decimal.Parse(campos[3]), campos[4], DateTime.Parse(campos[5]), DateTime.Parse(campos[6]));
                poliza.Id = int.Parse(campos[0]);
                resultado.Add(poliza);
            }
            return resultado;
        }
    }
}