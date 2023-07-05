public class Program
{
    public static void Main()
    {
        int numberOfPeople = 0;
        int numberOfChildren = 0;
        int age = 99;

        while (age > 0)
        {

            Console.WriteLine("Informe a idade. INFORME 0 p sair");
            age = Convert.ToInt32(Console.ReadLine());
            if (age == 0) break;
            numberOfPeople++;
            if (age < 18) numberOfChildren++;
        }
        double percentage = 0;
        if (numberOfPeople > 0)
        {
            percentage = 100 * numberOfChildren / numberOfPeople;

        }
        Console.WriteLine("existe:" + percentage + "% de crianças");
    }
}
