public class Program
{
    public static void Main(string[] args)
    {
        var wolf = new Wolf();
        var cow = new Cow();
        AnimalInfo(wolf);
        AnimalInfo(cow);

    }

    public static void AnimalInfo(Animal animal)
    {
        Console.WriteLine($"{animal.GetType().Name} is also known as {animal.ScientificName}");
        animal.Eat();
    }
}