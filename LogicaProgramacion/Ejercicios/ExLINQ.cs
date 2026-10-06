using System.Linq;

namespace LogicaProgramacion;

public class ExLINQ
{
    public void imprimirLista(List<int> n)
    {
        n.ForEach(elemento => Console.Write(elemento + ", "));
    }

    public void filtrarCalificaciones()
    {
        List<int> calificaciones = new List<int> { 15, 8, 12, 6, 18, 10, 14, 20, 9, 4, 11 };
        List<int> aprobados;
        List<int> reprobados;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("     Calificaciones Totales");
        Console.WriteLine("---------------------------------");
        imprimirLista(calificaciones);
        Console.WriteLine("\n---------------------------------");
        aprobados = calificaciones.Where(n => n >= 11).ToList();

        Console.WriteLine("Calificaciones Aprobadas");
        imprimirLista(aprobados);
        reprobados = calificaciones.Where(n => n < 11 && n % 2 == 0).ToList();
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("Calificaciones Reprobadas y Pares");
        imprimirLista(reprobados);

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine("Cantidad De Notas Excelentes");
        var countExcelentes = calificaciones.Count(n => n >= 18);
        Console.WriteLine(countExcelentes);
    }
}