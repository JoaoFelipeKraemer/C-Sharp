public class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe número de lados");
        string? numberSide = Console.ReadLine();
        int numberSides = Convert.ToInt32(numberSide);
        string name = "";
        // string name = String.Empty;
        if (numberSides == 3)
        {
            name = "Triangulo";
        }
        else if (numberSides == 4)
        {
            name = "Quadrado";
        }
        else if (numberSides == 5)
        {
            name = "Pentagono";
        }
        else if (numberSides == 6)
        {
            name = "Hexagono";
        }
        else
        {
            name = "Polígono zoado";
        }
        Console.WriteLine("O polígono é: " + name);
        string complexity;
        switch (numberSides)
        {
            case 3:
            case 4:
            case 5:
                complexity = "básico";
                break;

            default:
                complexity = "complexo";
                break;
        }
        Console.WriteLine(complexity);
    }
}
