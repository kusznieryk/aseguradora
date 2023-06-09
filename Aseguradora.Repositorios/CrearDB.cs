
namespace Aseguradora.Repositorios
{
    public static class CrearDB
    {
        public static void Crear()
        {
            using (var context = new AseguradoraContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}