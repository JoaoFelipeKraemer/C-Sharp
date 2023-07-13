
public abstract class Animal
{
    public abstract string ScientificName { get; }
    public abstract bool CanEatMeat { get; }
    public abstract bool CanEatVegetables { get; }

    public void Eat()
    {
        var animal = this.GetType().Name.ToLower();
        string food;
        if (CanEatMeat && CanEatVegetables)
        {
            var random = new Random();
            food = random.Next(0, 2) == 0 ? "meat" : "vegetables";
        }
        else if (CanEatMeat) food = "meat";
        else if (CanEatVegetables) food = "vegetables";
        else throw new InvalidOperationException($"{animal} can't eat");
        Console.WriteLine($"The {animal} has eaten some {food}");
    }
}