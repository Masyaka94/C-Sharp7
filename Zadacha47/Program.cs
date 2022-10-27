// Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

void FillArray(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write($"Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[m, n];


FillArray(matrix);
PrintArray(matrix);