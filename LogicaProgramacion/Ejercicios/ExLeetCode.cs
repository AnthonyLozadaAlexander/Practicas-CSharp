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
        indexs = [0,0]; // Inicializamos el arreglo de índices con valores predeterminados

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if(sum.Equals(target))
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
}