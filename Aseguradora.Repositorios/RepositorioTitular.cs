using Aseguradora.Aplicacion;
namespace Aseguradora.Repositorios
{
    public class RepositorioTitular : IRepositorioTitular
    {

        public void AgregarTitular(Titular titular)
        {
            using (var context = new AseguradoraContext())
            {
                bool existe = context.Titulares.FirstOrDefault(t => t.Dni == titular.Dni) !=null;
                if (!existe)
                {
                    context.Titulares.Add(titular);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Ya existe un Titular con ese DNI ");
                }
            }
        }

        public void ModificarTitular(Titular titular)
        {
            using (var context = new AseguradoraContext())
            {
                var titularViejo = context.Titulares.FirstOrDefault(t => t.Dni == titular.Dni);
                if (titularViejo != null)
                {
                    titularViejo.Apellido = titular.Apellido;
                    titularViejo.Nombre = titular.Nombre;
                    titularViejo.Direccion = titular.Direccion;
                    titularViejo.Telefono = titular.Telefono;
                    titularViejo.Email = titular.Email;
                    context.SaveChanges();
                }
            }
        }

        public void EliminarTitular(int dni)
        {
            using (var context = new AseguradoraContext())
            {
                var titular = context.Titulares.FirstOrDefault(t => t.Dni == dni);
                if (titular != null)
                {
                    context.Remove(titular);
                    context.SaveChanges();
                }
            }
        }

        public List<Titular> ListarTitulares()
        {
            using (var context = new AseguradoraContext())
            {
                return context.Titulares.ToList();
            }
        }
    }
}