void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random n_new = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
        }
    }
}

Console.Write("Print, how many rows will contain your massive: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Print, how many columns will contain your massive: ");
int tabs = int.Parse(Console.ReadLine());

double[,] matrix = new double[tabs, rows];
FillArray(matrix);
PrintArray(matrix);