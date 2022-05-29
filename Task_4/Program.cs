// Задача 4. Дополнительное задание
// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

string FindNumber(int[,] matr, int num)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == num) return $"Your number ({num}) on position {(i+1,j+1)}";
        }
    }
    return $"There are no such number ({num})";
}

int[,] matrix = new int[4,4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(FindNumber(matrix, 4));