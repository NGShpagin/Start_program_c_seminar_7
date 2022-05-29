// Задача 3. Решение в группах задач
// Задайте двумерный массив. Найдите сумму элементов главной диагонали.

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
            matr[i, j] = new Random().Next(3, 10);
        }
    }
}

int CountSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum += matr[i, j];
        }
    }
    return sum;
}


int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"Sum = {CountSum(matrix)}");