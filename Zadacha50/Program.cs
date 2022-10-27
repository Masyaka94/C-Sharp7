/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/


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
    for (int rows = 0; rows<matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns<matr.GetLength(1); columns++)
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

Console.Write($"Введите первый индекс элемента: ");
int indexStr = int.Parse(Console.ReadLine());

Console.Write($"Введите второй индекс элемента: ");
int indexStl = int.Parse(Console.ReadLine()!);

if (indexStr <= m-1 && indexStl <= n-1)
{
    Console.Write($"Элемент: {matrix[indexStr, indexStl]} ");
}
else
{
    Console.Write($"Заданные индексы вне массива ");
}
