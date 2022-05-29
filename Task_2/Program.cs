// Задача 1. Решение в группах задач
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

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
            matr[i, j] = i + j; 
            // row = 0, column = 0, mean = 0 + 0 = 0
            // row = 0, column = 1, mean = 0 + 1 = 1
            // row = 0, column = 2, mean = 0 + 2 = 2
            // row = 0, column = 3, mean = 0 + 3 = 3

            // row = 1, column = 0, mean = 1 + 0 = 1
            // row = 1, column = 1, mean = 1 + 1 = 2
            // row = 1, column = 2, mean = 1 + 2 = 3
            // row = 1, column = 3, mean = 1 + 3 = 4

            // row = 2, column = 0, mean = 2 + 0 = 2
            // row = 2, column = 1, mean = 2 + 1 = 3
            // row = 2, column = 2, mean = 2 + 2 = 4
            // row = 2, column = 3, mean = 2 + 3 = 5
        }
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);