// Задача 2. Решение в группах задач
// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

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

void SqrArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) matr[i, j] *= matr[i, j];
        }
    }
}


int[,] matrix = new int[4,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SqrArray(matrix);
PrintArray(matrix);