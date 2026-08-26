namespace LogicaProgramacion;

public class ExLogica
{

    // Ejercicio para determinar si un anio es bisisesto
    public bool EjercicioAnioBisisesto()
    {
        bool result = false;
        int anio = 0;

        Console.WriteLine("Ingrese El Año: ");
        anio = Int32.Parse(Console.ReadLine());
        if (anio.Equals(null) || anio <= 0)
        {
            Console.WriteLine("El anio ingresado no es valido");

        }
        else if (anio % 4 == 0)
        {
            result = true;
            if (anio % 100 == 0)
            {
                result = false;
                if (anio % 400 == 0)
                {
                    result = true;
                }
            }
        }

        return result;
    }

    // Ejercicio para determinar la secuencia de Fibonacci

    public void EjercicioFibonacci()
    {
        int c = 0, a = 0, b = 1, n = 0;
        Console.WriteLine("Ingrese el limite de la secuencia: ");
        n = Int32.Parse(Console.ReadLine());
        Console.Write($"{a} , {b} ,");
        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                if (i < n - 1)
                {
                    Console.Write($" {c}");
                    Console.Write(" ,");
                }
                else
                {
                    Console.Write($" {c}");
                }

                a = b;
                b = c;
            }
        }

    }
}

