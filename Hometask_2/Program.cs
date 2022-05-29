void PrintArray(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

string FindNum(int[,] matr, int row, int tab)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == row-1 && j == tab-1) return $"On position [{row}, {tab}] the number - {matr[i,j]}";
        }
    }
    return $"There are no position [{row}, {tab}] in our massive";
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);

Console.Write("Print the number of row: ");
int num_row = int.Parse(Console.ReadLine());
Console.Write("Print the number of table: ");
int num_table = int.Parse(Console.ReadLine());
Console.WriteLine(FindNum(matrix, num_row, num_table));