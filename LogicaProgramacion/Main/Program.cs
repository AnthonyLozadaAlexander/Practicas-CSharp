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
                    Console.WriteLine("3. Ejercicio Inversion Arreglo");
                    Console.WriteLine("4. Ejercicio Contador Maximo De Racha");
                    Console.WriteLine("5. Ejercicio Mover Ceros");
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

                        case "3":
                            int[] a = { 10, 20, 30, 40, 50, 60 };
                            Console.WriteLine("\nArreglo Original:");
                            for (int i = 0; i < a.Length; i++)
                            {
                                Console.WriteLine($"Index[{i}] = {a[i]}");
                            }

                            Console.WriteLine("\nArreglo Invertido:");
                            Logica.invertirArreglo(a);
                            for (int i = 0; i < a.Length; i++)
                            {
                                Console.WriteLine($"Index[{i}] = {a[i]}");
                            }

                            break;
                        case "4":

                            int[] registros = { 1, 1, 1, 0, 1, 1, 1, 1 };
                            Console.WriteLine("\nArreglo De Registros");
                            leerArreglo(registros);
                            int racha = LeetCode.encontrarRachaMax(registros);
                            Console.WriteLine($"\nLa Racha fue De: {racha} Dias Conectados");

                            break;
                        case "5":

                            int[] nums = { 0, 1, 0, 3, 21 };
                            leerArreglo(nums);
                            int k = 0;
                            LeetCode.remplazarCeros(nums, k, 0);

                            Console.WriteLine("\nArreglo Con Ceros Movidos Al Final");
                            leerArreglo(nums);
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

        public static void leerArreglo(int[] arr)
        {
            Console.Write("\n[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write($"{arr[i]}");
                }
                else
                {
                    Console.Write($"{arr[i]}, ");
                }
            }
            Console.Write(" ]\n");
        }
    }
}
