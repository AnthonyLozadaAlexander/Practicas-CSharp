namespace LogicaProgramacion;

public class EjerciciosLogica
{
    public bool EjercicioAnioBisisesto()
    {
        bool result = false;
        int anio = 0;
        
        Console.WriteLine("Ingrese El Año: ");
        anio = Int32.Parse(Console.ReadLine());
        if (anio.Equals(null) || anio <= 0)
        {
            Console.WriteLine("El anio ingresado no es valido");
            
        }else if (anio % 4 == 0)
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
}

