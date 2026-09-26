using System.ComponentModel.DataAnnotations;

namespace LogicaProgramacion;

public class ExLeetCode
{
    public int MissingNumber(int[] nums)
    {
        int n = 0, sumReal = 0, sumExpected = 0, missingNumber = 0;
        n = nums.Length;

        foreach (int r in nums)
        {
            sumReal = sumReal + r;
        }

        sumExpected = ((n * (n + 1)) / 2);

        missingNumber = sumExpected - sumReal;

        return missingNumber;
    }

    /*
    Dado un arreglo de números enteros llamado nums y un número entero llamado target (objetivo), debes encontrar dos números dentro del arreglo que, al sumarse, den exactamente el valor de target.
    Tu función debe devolver los índices (las posiciones) de esos dos números en un nuevo arreglo.

Puedes asumir que siempre habrá exactamente una solución válida, y no puedes usar el mismo elemento del arreglo dos veces (es decir, no puedes sumar el número de la posición 0 consigo mismo).

Ejemplos:

Ejemplo 1:

  Entrada: nums = [2, 7, 11, 15], target = 9

Salida: [0, 1]

  Explicación: Como nums[0] + nums[1] (2 + 7) es igual a 9, retornamos [0, 1].

Ejemplo 2:

  Entrada: nums = [3, 2, 4], target = 6

Salida: [1, 2]

Explicación: nums[1] + nums[2] (2 + 4) es igual a 6.
    */

    public int[] TwoSum(int[] nums, int target)
    {
        int sum = 0;
        int[] indexs = new int[2];
        indexs = [0, 0]; // Inicializamos el arreglo de índices con valores predeterminados

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if (sum.Equals(target))
                {
                    indexs[0] = i;
                    indexs[1] = j;
                    j = nums.Length; // Salir del bucle interno
                    i = nums.Length; // Salir del bucle externo
                }
            }

        }

        return indexs;

    }

    /* Enunciado:
    Imagina que estás analizando el registro de actividad de un usuario en un sistema. Tienes un arreglo de números enteros llamado registros que únicamente contiene 1 (usuario conectado) y 0 (usuario desconectado).

    Tu misión es crear una función que recorra este arreglo y devuelva el número máximo de días consecutivos que el usuario estuvo conectado.

    Ejemplos:

    Ejemplo 1:

    Entrada: registros = [1, 1, 0, 1, 1, 1]

    Salida: 3

    Explicación: Los primeros dos días se conectó (racha de 2). Luego se desconectó (la racha se rompe). Luego se conectó tres días seguidos (racha de 3). La racha más larga es 3.

    Ejemplo 2:

    Entrada: registros = [1, 0, 1, 1, 0, 1]

    Salida: 2 */

    public int encontrarRachaMax(int[] registros)
    {
        int racha = encontrarRachaMaxR(registros, 0, 0, 0);
        return racha;
    }

    private int encontrarRachaMaxR(int[] registros, int i, int count, int countMaximo)
    {
        if (i >= registros.Length)
        {
            return countMaximo;
        }

        if (registros[i] == 1)
        {
            count++;
            countMaximo = Math.Max(count, countMaximo); // contadorRachaMaxima 
        }
        else
        {
            count = 0; // reinicia contadorActual
        }

        count = encontrarRachaMaxR(registros, i + 1, count, countMaximo);

        return count;
    }

    /* Ejercicio: Mover Ceros al Final(Move Zeroes)
Enunciado:
Dado un arreglo de números enteros nums, debes mover todos los ceros(0) al final del arreglo, manteniendo intacto el orden original de los números que no sean cero.

Restricción importante:
Debes modificar el arreglo directamente(in -place).No puedes crear un segundo arreglo auxiliar para copiar los valores.

Ejemplos:

Ejemplo 1:

Entrada: nums = [0, 1, 0, 3, 12]

Salida: [1, 3, 12, 0, 0]

Ejemplo 2:

Entrada: nums = [0]

Salida: [0]

Ejemplo 3:

Entrada: nums = [4, 0, 5, 0, 1]

Salida: [4, 5, 1, 0, 0] */


    public void moverCeros(int[] nums, int i, int counts)
    {
        int n = nums.Length;

        if (i < n)
        {
            if (nums[i] != 0)
            {
                nums[i - counts] = nums[i];
            }
            else
            {
                counts++;
            }

            moverCeros(nums, i + 1, counts);

            if (counts > 0)
            {
                nums[n - counts] = 0;
            }
        }

    }
}