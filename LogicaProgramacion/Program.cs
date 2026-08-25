using System;

namespace LogicaProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            ExLogica Logica = new ExLogica();
            ExLeetCode LeetCode = new ExLeetCode(); 
            
            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("1. Ejercicios Logica");
            Console.WriteLine("2. Ejercicios LeetCode");
            Console.WriteLine("--------------------------");
            Console.Write("Seleccione Una Opcion: "); String opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    /*result = Logica.EjercicioAnioBisisesto();
            Console.WriteLine("El anio ingresado es Bisiesto: " + (result ? "Si" : "No"));*/
                   // Logica.EjercicioFibonacci();
                    
                    break;
                case "2":
                    int r = LeetCode.MissingNumber(new int[] { 3, 0, 1 });
                    Console.WriteLine("Result: " + r);
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }
            
            
        }
    }
}
