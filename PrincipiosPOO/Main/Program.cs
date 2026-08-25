using System;
using PrincipiosPOO.Clases;

namespace PrincipiosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            String op = "";
            Console.WriteLine("Principios De POO en C#");
            Console.WriteLine("1. Clases y Objetos");
            Console.WriteLine("2. Constructores");
            Console.Write("Selecciones -> ");
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

                    break;

                default:

                    Console.WriteLine("Opcion No Valida");

                    break;

            }
        }
    }
}

