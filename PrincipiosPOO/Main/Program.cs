using System;
using PrincipiosPOO.Clases;
using PrincipiosPOO.Constructores;

namespace PrincipiosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            String op = "";
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("            Principios De POO en C#");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. Clases y Objetos");
            Console.WriteLine("2. Constructores");
            Console.Write("Selecciones Opcion -> ");
            op = Console.ReadLine();
            switch (op)
            {

                case "1":
                    // Creamos el objeto de la clase Human
                    Human francisco = new Human();
                    francisco.Name = "Francisco";
                    francisco.Height = 1.69;
                    francisco.weight = 82;
                    francisco.Age = 22;

                    String info = $"\nInformacion Del Objeto Francisco: \n" +
                                  $"Nombre: {francisco.Name} \n" +
                                  $"Altura: {francisco.Height} \n" +
                                  $"Peso: {francisco.weight} kg \n" +
                                  $"Edad: {francisco.Age} anios \n";

                    Console.WriteLine(info);

                    francisco.comer("Pizza");
                    francisco.respirar();
                    francisco.ejercicio();
                    francisco.caminar();

                    break;
                case "2":
                    String infoCuentaAhorros = "", infoCuentaCorriente = "";
                    BankAccount cuenta = new BankAccount("Francisco"); // cuenta con parametro
                    BankAccount cuenta1 = new BankAccount(); // cuenta con valor default
                    BankAccount cuentaAhorros = new BankAccount();
                    BankAccount cuentaCorriente = new BankAccount("Francisco Perez");


                    Console.WriteLine($"\nCuenta 1: {cuenta.Owner}");
                    Console.WriteLine($"Cuenta 2: {cuenta1.Owner}\n");

                    System.Console.WriteLine("------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Green;

                    // cuentaAhorros.accountNumber = 0983362883;
                    cuentaAhorros.generarNumeroCuenta();
                    cuentaAhorros.Amount = 1500;
                    // cuentaAhorros.isActive = true;

                    infoCuentaAhorros = $"\n Informacion De La Cuenta De Ahorros: \n" +
                                    $"Numero Cuenta: {cuentaAhorros.accountNumber} \n" +
                                    $"Monto: {cuentaAhorros.Amount} $\n" +
                                    $"Estado: {cuentaAhorros.isActive} \n";

                    Console.WriteLine(infoCuentaAhorros);

                    System.Console.WriteLine("------------------------------------------------");

                    Console.ForegroundColor = ConsoleColor.Blue;

                    cuentaCorriente.Amount = 980;
                    // cuentaCorriente.isActive = true;

                    infoCuentaCorriente = $"\n Informacion De La Cuenta De Corriente: \n" +
                                    $"Numero Cuenta: {cuentaCorriente.accountNumber} \n" +
                                    $"Monto: {cuentaCorriente.Amount} $\n" +
                                    $"Estado: {cuentaCorriente.isActive} \n";

                    Console.WriteLine(infoCuentaCorriente);

                    break;

                default:

                    Console.WriteLine("Opcion No Valida");

                    break;

            }
        }
    }
}

