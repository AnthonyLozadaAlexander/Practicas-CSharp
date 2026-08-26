Console.ForegroundColor = ConsoleColor.Blue;
string passAdmin = "admin2026";
string userAdmin = "@dmin";
string nombre = "", contrasenia = "";
int count = 3;
bool acceso = false;

Console.WriteLine("\n---------------------------------------");
Console.WriteLine("Bienvenido Al Sistema De Autenticacion");
Console.WriteLine("---------------------------------------\n");
do
{
    Console.WriteLine("Ingrese su nombre de usuario");
    Console.Write("-> ");
    nombre = Console.ReadLine();
    Console.WriteLine("\nIngrese su contrasenia");
    Console.Write("-> ");
    contrasenia = Console.ReadLine();

    if (!(nombre.Equals(userAdmin)))
    {
        count = count - 1;
        Console.WriteLine($"\n Usuario Incorrecto. Te  quedan [{count}] Intentos\n");
        continue; // va directo al siguiente ciclo del bucle
    }

    if (!(contrasenia.Equals(passAdmin)))
    {
        count = count - 1;
        Console.WriteLine($"\n Contrasenia Incorrecta. Te  quedan [{count}] Intentos\n");
    }
    else
    {
        Console.WriteLine($"\n!Acceso Concedido! Bienvenido {nombre}");
        count = 0;
        acceso = true;
    }

} while (count > 0);


if (!acceso)
{
    Console.WriteLine("\nSISTEMA BLOQUEADO.\n Contacte al administrador del sistema.");
}
