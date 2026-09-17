using System;
// escribir commits en espaniol
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
            Console.Write("Seleccione Una Opcion -> "); string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n1. Ejercicio Anio Bisiesto");
                    Console.WriteLine("2. Ejercicio Fibonacci");
                    Console.WriteLine("3. Ejercicio Ingrese 3 Numeros y Imprima Descendente");
                    Console.Write("Seleccione Una Opcion -> "); string opc = Console.ReadLine();
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
                            Logica.EjercicioTresNumerosDescendentes();
                            break;

                        default:
                            Console.WriteLine("Opcion Invalida");
                            break;
                    }

                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n1. Ejercicio Missing Number");
                    Console.WriteLine($"2. Ejercicio Two Sum");
                    Console.Write("Seleccione Una Opcion -> ");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            int r = LeetCode.MissingNumber(new int[] { 3, 0, 1 });
                            Console.WriteLine("Result: " + r);
                            break;
                        case "2":
                            int[] arr;
                            Console.WriteLine("Ingrese El Tamanio Del Arreglo");
                            Console.Write(" -> "); int size = Convert.ToInt32(Console.ReadLine());
                            arr = new int[size];

                            Console.WriteLine("Ingrese Los Elementos Del Arreglo");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                Console.Write($"[{i}]: "); 
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }

                            Console.WriteLine("Ingrese El Target");
                            Console.Write(" -> "); int target = Convert.ToInt32(Console.ReadLine());

                            int[] result = LeetCode.TwoSum(arr, target);

                            for (int i = 0; i < result.Length; i++)
                            {
                                Console.WriteLine($"Index = {result[i]}");
                            }

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
