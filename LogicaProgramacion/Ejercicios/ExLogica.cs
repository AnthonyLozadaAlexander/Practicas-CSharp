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

    public void EjercicioTresNumerosDescendentes()
    {
        int a = 0;
        int b = 0;
        int c = 0;

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("A: " + a);
        Console.Write(" -> ");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("B: " + b);
        Console.Write(" -> ");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine("C: " + c);
        Console.Write(" -> ");
        c = Int32.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------------------");

        if (a >= b && a >= c)
        {
            Console.WriteLine("A: " + a);
            if (b >= c)
            {
                Console.WriteLine("B: " + b);
                Console.WriteLine("C: " + c);
            }
            else
            {
                Console.WriteLine("C: " + c);
                Console.WriteLine("B: " + b);
            }
        }
        else if ((c >= a) && (c >= b))
        {
            Console.WriteLine("C: " + c);
            if (a >= b)
            {
                Console.WriteLine("A: " + a);
                Console.WriteLine("B: " + b);
            }
            else
            {
                Console.WriteLine("B: " + b);
                Console.WriteLine("A: " + a);
            }
        }
        else
        {
            Console.WriteLine("B: " + b);
            if (a >= c)
            {
                Console.WriteLine("A: " + a);
                Console.WriteLine("C: " + c);
            }
            else
            {
                Console.WriteLine("C: " + c);
                Console.WriteLine("A: " + a);
            }
        }
        
        Console.WriteLine("---------------------------------------");
    }
}

