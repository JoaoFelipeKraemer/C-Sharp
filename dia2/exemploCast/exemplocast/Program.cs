public class Program
{
    public static void Main()
    {
        // mostrar valor
        // pedir para digitar numero de parcelas
        // informar valor da parcela
        double totalValue = 152.60;
        Console.WriteLine("valor total é " + totalValue);
        string? parcelas = Console.ReadLine();
        int convertParcelas = Convert.ToInt32(parcelas);
        double amount = totalValue / convertParcelas;
        Console.WriteLine("O valor da parcela é: " + amount);
    }
}