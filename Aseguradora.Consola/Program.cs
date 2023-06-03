using Aseguradora.Aplicacion;
using Aseguradora.Repositorios;

IRepositorioTitular repoTitular = new RepositorioTitular();
AgregarTitularUseCase agregarTitular = new AgregarTitularUseCase(repoTitular);
ListarTitularesUseCase listarTitulares = new ListarTitularesUseCase(repoTitular);
ModificarTitularUseCase modificarTitular = new ModificarTitularUseCase(repoTitular);
EliminarTitularUseCase eliminarTitular = new EliminarTitularUseCase(repoTitular);

IRepositorioVehiculo repoVehiculo = new RepositorioVehiculo();
AgregarVehiculoUseCase agregarVehiculo = new AgregarVehiculoUseCase(repoVehiculo, repoTitular);
ListarVehiculosUseCase listarVehiculos = new ListarVehiculosUseCase(repoVehiculo);
ModificarVehiculoUseCase modificarVehiculo = new ModificarVehiculoUseCase(repoVehiculo);
EliminarVehiculoUseCase eliminarVehiculo = new EliminarVehiculoUseCase(repoVehiculo);

IRepositorioPoliza repoPoliza = new RepositorioPoliza();
AgregarPolizaUseCase agregarPoliza = new AgregarPolizaUseCase(repoPoliza, repoVehiculo);
ListarPolizasUseCase listarPolizas = new ListarPolizasUseCase(repoPoliza);
ModificarPolizaUseCase modificarPoliza = new ModificarPolizaUseCase(repoPoliza);
EliminarPolizaUseCase eliminarPoliza = new EliminarPolizaUseCase(repoPoliza);

//Instanciamos un titular
Titular titular = new Titular(33123456, "García", "Juan")
{
    Direccion = "13 nro. 546",
    Telefono = "221-456456",
    Email = "joseGarcia@gmail.com"
};

//Instanciamos un Vehiculo
Vehiculo vehiculo = new Vehiculo("AF 209 EE", "Ford", 2023, 1);

//Instanciamos una Poliza
Poliza poliza = new Poliza(1, 20000.5M, 10000, "TodoRiesgo", new DateTime(2020, 10, 30), new DateTime(2025, 12, 15));

Console.WriteLine($"\nId del titular recién instanciado: {titular.Id}");

Console.WriteLine($"\nId del Vehiculo recién instanciado: {vehiculo.Id}");

Console.WriteLine($"\nId de la Poliza recién instanciada: {poliza.Id}");
//agregamos el titular utilizando un método local
PersistirTitular(titular);

//agregamos el Vehiculo utilizando un método local
PersistirVehiculo(vehiculo);

//agregamos la Poliza utilizando un método local
PersistirPoliza(poliza);

//el id que corresponde al titular es establecido por el repositorio
Console.WriteLine($"\nId del titular una vez persistido: {titular.Id}");

//el id que corresponde al Vehiculo es establecido por el repositorio
Console.WriteLine($"\nId del Vehiculo una vez persistido: {vehiculo.Id}");

//el id que corresponde a la Poliza es establecido por el repositorio
Console.WriteLine($"\nId de la Poliza una vez persistida: {poliza.Id}");
//agregamos unos titulares más
PersistirTitular(new Titular(20654987, "Rodriguez", "Ana"));
PersistirTitular(new Titular(31456444, "Alconada", "Fermín"));
PersistirTitular(new Titular(12345654, "Perez", "Cecilia"));

//listamos los titulares utilizando un método local
ListarTitulares();

//agregamos unos Vehiculos más
PersistirVehiculo(new Vehiculo("BAE 193", "Ford", 1999, 1));
PersistirVehiculo(new Vehiculo("JLT 880", "Chevrolet", 2010, 2));
PersistirVehiculo(new Vehiculo("AE 007 LM", "Fiat", 2022, 3));

//listamos los Vehiculos utilizando un método local
ListarVehiculos();

//agregamos unas Polizas más
PersistirPoliza(new Poliza(4, 26500.5M, 1000, "TodoRiesgo", new DateTime(2001, 09, 11), new DateTime(2025, 12, 14)));
PersistirPoliza(new Poliza(2, 4000.5M, 5000, "TodoRiesgo", new DateTime(2022, 12, 08), new DateTime(2026, 08, 19)));
PersistirPoliza(new Poliza(3, 60000.5M, 70000, "ResponsabilidadCivil", new DateTime(2003, 1, 3), new DateTime(2025, 12, 23)));

//listamos las Polizas utilizando un método local
ListarPolizas();

//no debe ser posible agregar un titular con igual DNI que uno existente
Console.WriteLine("\nIntentando agregar un titular con DNI 20654987");
titular = new Titular(20654987, "Alvarez", "Alvaro");

PersistirTitular(titular); //este titular no pudo persistirse

//Entonces vamos a modificar el titular existente
Console.WriteLine("\nModificando el titular con DNI 20654987");
modificarTitular.Ejecutar(titular);
ListarTitulares();

//Eliminando un titular
Console.WriteLine("\nEliminando al titular con id 1");
eliminarTitular.Ejecutar(1);
ListarTitulares();
//no debe ser posible agregar un Vehiculo con igual dominio que uno existente
Console.WriteLine("\nIntentando agregar un vehiculo con dominio BAE 193 ");
vehiculo = new Vehiculo("BAE 193", "Audi", 2015, 2);

PersistirVehiculo(vehiculo); //este Vehiculo no pudo persistirse

//Modificamos un Vehiculo existente
Console.WriteLine("\nModificando el Vehiculo con Dominio BAE 193");
modificarVehiculo.Ejecutar(vehiculo);
ListarVehiculos();

//Eliminando un Vehiculo
Console.WriteLine("\nEliminando al Vehiculo con id 1");
eliminarVehiculo.Ejecutar(1);
ListarVehiculos();
//no debe ser posible agregar una Poliza a un vehiculo con esa misma cobertura
Console.WriteLine("\nIntentando agregar una poliza al vehiculo con id 2 que ya tiene cobertura TodoRiesgo");
poliza = new Poliza(2, 2000.5M, 4000, "TodoRiesgo", new DateTime(2021, 11, 09), new DateTime(2024, 07, 22));

PersistirPoliza(poliza); //esta Poliza no pudo persistirse

//Modificamos una Poliza existente
Console.WriteLine("\nModificando la Poliza con Mismo vehiculo id y cobertura");
modificarPoliza.Ejecutar(poliza);
ListarPolizas();

//Eliminando una Poliza
Console.WriteLine("\nEliminando la Poliza con id 1");
eliminarPoliza.Ejecutar(1);
ListarPolizas();

ListarTitularesConSusVehiculosUseCase listarTitularesConSusVehiculosUseCase = new ListarTitularesConSusVehiculosUseCase(repoTitular, repoVehiculo);

List<Titular> titu= listarTitularesConSusVehiculosUseCase.Ejecutar();

Console.WriteLine("\nListando todos los titulares con sus respectivos vehiculos ");
foreach (var t in titu)
{
    Console.Write("\nListando titular: ");
    Console.WriteLine(t);
    List<Vehiculo> vehiu=t.ListaVehiculos;
    foreach (var v in vehiu)
    {
        Console.WriteLine("    "+v); 
    }
}


//métodos locales para mejorar legibilidad
void PersistirTitular(Titular t)
{
    try
    {
        agregarTitular.Ejecutar(t);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void ListarTitulares()
{
    Console.WriteLine("Listando todos los titulares de vehículos");
    List<Titular> lista = listarTitulares.Ejecutar();
    foreach (Titular t in lista)
    {
        Console.WriteLine(t);
    }
}

void PersistirVehiculo(Vehiculo t)
{
    try
    {
        agregarVehiculo.Ejecutar(t);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void ListarVehiculos()
{
    Console.WriteLine("Listando todos los vehículos");
    List<Vehiculo> lista = listarVehiculos.Ejecutar();
    foreach (Vehiculo t in lista)
    {
        Console.WriteLine(t);
    }
}

void PersistirPoliza(Poliza t)
{
    try
    {
        agregarPoliza.Ejecutar(t);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void ListarPolizas()
{
    Console.WriteLine("Listando todas las polizas");
    List<Poliza> lista = listarPolizas.Ejecutar();
    foreach (Poliza t in lista)
    {
        Console.WriteLine(t);
    }
}