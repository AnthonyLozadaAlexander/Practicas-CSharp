using System;

namespace LogicaProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ExLogica Logica = new ExLogica();
            ExLeetCode LeetCode = new ExLeetCode();

            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("1. Ejercicios Logica");
            Console.WriteLine("2. Ejercicios LeetCode");
            Console.WriteLine("--------------------------");
            Console.Write("Seleccione Una Opcion: "); string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("1. Ejercicio Anio Bisiesto");
                    Console.WriteLine("2. Ejercicio Fibonacci");
                    Console.WriteLine("3. Ejercicio ");
                    string opc = Console.ReadLine();
                    switch (opc)
                    {
                        case "1":
                            bool result = false;
                            result = Logica.EjercicioAnioBisisesto();
                            Console.WriteLine("El anio ingresado es Bisiesto: " + (result ? "Si" : "No"));
                            break;
                        case "2":
                            Logica.EjercicioFibonacci();
                            break;
                        case "3":
                            break;

                        default:
                            Console.WriteLine("Opcion Invalida");
                            break;
                    }

                    break;
                case "2":
                    System.Console.WriteLine("1. Ejercicio Missing Number");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            int r = LeetCode.MissingNumber(new int[] { 3, 0, 1 });
                            Console.WriteLine("Result: " + r);
                            break;
                        default:
                            Console.WriteLine("Opcion Invalida");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }


        }
    }
}
