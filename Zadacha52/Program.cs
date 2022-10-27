/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце*/

void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-100, 100);
        }
    }
}

void PrintArray(int[,] matr)
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

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

for (int columns = 0; columns < matrix.GetLength(1); columns++)
{
    double average = 0;
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        average += matrix[rows, columns];
    }
    Console.WriteLine($"Среднее арифметическое столбцов: {average / matrix.GetLength(0)}");
}