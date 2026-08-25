namespace PrincipiosPOO.Clases;

public class Human
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double weight { get; set; }
    public int Age { get; set; }

    public void comer(String comida)
    {
        Console.WriteLine($"{Name} esta comiendo {comida}");
        weight = weight + 0.5;
        Console.WriteLine($"{Name} ahora pesa {weight} kg\n");
    }

    public void respirar()
    {
        Console.WriteLine($"{Name} esta respirando\n");
    }

    public void ejercicio()
    {
        Console.WriteLine($"{Name} esta haciendo ejercicio");
        weight = weight - 0.5;
        Console.WriteLine($"{Name} ahora pesa  {weight} kg\n");

    }

    public void caminar()
    {
        Console.WriteLine($"{Name} esta caminando");
        weight = weight - 0.2;
        Console.WriteLine($"{Name} ahora pesa  {weight} kg\n");
    }
}