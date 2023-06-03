using Aseguradora.Aplicacion;
namespace Aseguradora.Repositorios
{
    public class RepositorioTitular : IRepositorioTitular
    {
        private int _contador = 1;
        readonly string _nombreArch = "titulares.txt";
        public void AgregarTitular(Titular titular)//fachero
        {
            if (File.Exists(_nombreArch))
            {
                using var sr = new StreamReader(_nombreArch);
                while (!sr.EndOfStream)
                {
                    string? linea = sr.ReadLine() ?? "";
                    if (int.Parse(linea.Split('#')[1]) == titular.Dni)
                        throw new Exception($"Ya existe un titular con DNI = {titular.Dni}");
                }
            }
            using var sw = new StreamWriter(_nombreArch, true);
            titular.Id = _contador++;
            sw.WriteLine($"{titular.Id}#{titular.Dni}#{titular.Apellido}#{titular.Nombre}#{titular.Telefono}#{titular.Direccion}#{titular.Email}");

        }

        public void ModificarTitular(Titular titular)
        {
            using var sr = new StreamReader(_nombreArch);
            List<String> lineas = new List<string>();
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine() ?? "";
                if (int.Parse(linea.Split('#')[1]) != titular.Dni)
                {
                    lineas.Add(linea);
                }
                else
                {
                    titular.Id = int.Parse(linea.Split('#')[0]);
                    lineas.Add($"{titular.Id}#{titular.Dni}#{titular.Apellido}#{titular.Nombre}#{titular.Telefono}#{titular.Direccion}#{titular.Email}");
                }
            }
            using var sw = new StreamWriter(_nombreArch);
            foreach (string item in lineas)
            {
                sw.WriteLine(item);
            }
        }
        public void EliminarTitular(int id) //si es el que quiero eliminar no lo agrego a la lista la cual reescribo despues
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
        public List<Titular> ListarTitulares()
        {
            var resultado = new List<Titular>();
            using var sr = new StreamReader(_nombreArch);
            while (!sr.EndOfStream)
            {
                string[] campos = (sr.ReadLine() ?? "").Split('#');
                var titular = new Titular(int.Parse(campos[1]), campos[2], campos[3]);
                titular.Id = int.Parse(campos[0]);
                titular.Telefono = campos[4];
                titular.Email = campos[6] ?? "";
                titular.Direccion = campos[5] ?? "";
                resultado.Add(titular);
            }
            return resultado;
        }
    }
}