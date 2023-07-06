// Utilizando Arrays - Preenchendo Arrays simples
// class Program
// {
//     public int[] expensesCost;

//     static void Main(string[] args)
//     {
//         int[] expensesCost;
//         Console.WriteLine("Entre com o número de despesas: ");
//         int numberOfExpenses = getNumberOfExpenses();

//         for (int i = 0; i < numberOfExpenses; i++)
//         {
//             expensesCost[i] = getExpenseCostFromUser();
//         }
//         int totalExpenses = 0;

//         for (int i = 0; i < numberOfExpenses; i++)
//         {
//             totalExpenses += expensesCost[i];
//         }

//         Console.WriteLine("O total das despesas é: " + totalExpenses);
//     }
// }

// Utilizando Arrays - Preenchendo Arrays multidimensionais

// para q  cada despesa, sejam armazenados dois valores: um valor líquido e outro bruto.

// Nesse caso, para que a gente consiga armazenar dois valores para cada despesa

// class Program
// {
//     int[,] expensesCost;

//     static void Main(string[] args)
//     {
//         int[,] expensesCost;
//         Console.WriteLine("Entre com o número de despesas: ");
//         int numberOfExpenses = getNumberOfExpenses();

//         expensesCost = new int[numberOfExpenses, 2];

//         for (int i = 0; i < numberOfExpenses; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 expensesCost[i, j] = getExpenseCostFromUser();
//             }
//         }
//         int totalExpenses = 0;

//         for (int i = 0; i < numberOfExpenses; i++)
//         {
//             totalExpenses += expensesCost[i];
//         }

//         Console.WriteLine("O total das despesas é: " + totalExpenses);
//     }
// }