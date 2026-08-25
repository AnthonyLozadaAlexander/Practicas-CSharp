using PrincipiosPOO.Clases;

namespace PrincipiosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el objeto de la clase Human
            Human francisco = new Human();
            francisco.Name = "Francisco";
            francisco.Height = 1.69;
            francisco.weight = 82;
            francisco.Age = 22;

            String info = $"\nInformacion Del Objeto Francisco: \n" +
                          $"Nombre: {francisco.Name} \n" +
                          $"Altura: {francisco.Height} \n" +
                          $"Peso: {francisco.weight} kg \n" +
                          $"Edad: {francisco.Age} anios \n";

            Console.WriteLine(info);

            francisco.comer("Pizza");
            francisco.respirar();
            francisco.ejercicio();
            francisco.caminar();

        }
    }
}

