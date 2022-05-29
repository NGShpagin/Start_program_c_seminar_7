// Задача 1. Демонстрация решения
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

void FillArray(int[,] matr, int from, int to)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(from, to);
        }
    }
}


Console.Write("Print, how many columns will contain your matrix: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Print, how many rows will contain your matrix: ");
int rows = int.Parse(Console.ReadLine());

int[,] matrix = new int[columns, rows];
FillArray(matrix, 0, 10);
PrintArray(matrix);