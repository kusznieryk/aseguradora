using Microsoft.EntityFrameworkCore;
namespace Aseguradora.Repositorios
{
    public static class CrearDB
    {
        public static void Crear()
        {
            using (var context = new AseguradoraContext())
            {
                context.Database.EnsureCreated();
                var connection = context.Database.GetDbConnection();
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    //Console.WriteLine(context.Model.ToDebugString(Microsoft.EntityFrameworkCore.Infrastructure.MetadataDebugStringOptions.LongDefault));

                    command.CommandText = "PRAGMA journal_mode=DELETE;";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}