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

    public void EjercicioDeterminarTriangulo()
    {
        int a = 0;
        int b = 0;
        int c = 0;

        Console.WriteLine("Ingrese El Cateto A: "); a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese El Cateto B: "); b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese El Cateto C: "); c = Convert.ToInt16(Console.ReadLine());

        /// Todos sus catetos iguales
        if (a == b && b == c)
        {
            Console.WriteLine("El Triangulo Es Equilatero");

        }
        else if (a != b && b != c && c != a) // todos sus catetos diferentes/distintos
        {
            Console.WriteLine("Es un triangulo Escaleno");
        }
        else // Dos catetos Iguales y Uno Diferente
        {
            Console.WriteLine("Es un triangulo Isosceles");
        }
    }

    /*
    Desarrolla un programa en consola que actúe como una caja registradora básica. El sistema debe solicitar al usuario que ingrese el costo total de su compra. A partir de ese valor monetario, el programa debe aplicar reglas de negocio y mostrar en pantalla el monto final a pagar:

    Si la compra es menor a 50 dólares, no se aplica ningún descuento (paga el total exacto).

    Si la compra es desde 50 hasta 100 dólares (inclusive), se le aplica un 10% de descuento al total.

    Si la compra supera estrictamente los 100 dólares, recibe un 20% de descuento.
    */

    public void cajaBasica(double costoTotal)
    {
        double total = 0.0;
        double descuento = 0.0;

        if (costoTotal > 50 && costoTotal <= 100)
        {
            descuento = costoTotal * 0.10;

        }
        else if (costoTotal > 100)
        {
            descuento = costoTotal * 0.20;
        }

        Console.WriteLine("Compra Total: " + costoTotal);
        Console.WriteLine("Descuento Aplicado: " + descuento);

        total = costoTotal - descuento;

        Console.WriteLine("Total a Pagar: " + total);

    }

    /* Desarrolla un programa en consola que reciba un arreglo de números enteros y cambie el orden de sus elementos para que queden exactamente al revés. La restricción principal de este reto (lo que significa resolverlo "in-place") es que no puedes instanciar un segundo arreglo para ir copiando los números al revés. Debes modificar el arreglo original intercambiando los valores matemáticamente dentro de su propio espacio de memoria.

        Ejemplo de Ejecución:

        Entrada: [10, 20, 30, 40, 50]

        Salida: [50, 40, 30, 20, 10] */

    public void invertirArreglo(int[] arr)
    {
        int n = arr.Length;
        int aux_i = 0, aux_j = 0;
        int j = 0;
        int i = n - 1;

        while (i >= 0)
        {
            aux_j = arr[j];
            aux_i = arr[i];

            arr[j] = aux_i;
            arr[i] = aux_j;

            if (i == n / 2)
            {
                i = 0;
            }
            else
            {
                j++;
            }

            i--;
        }

    }
}

