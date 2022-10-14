// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
ReturnsValueElement(array2D);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine();
}

void ReturnsValueElement(int[,] matrix)
{
    Console.Write("Укажите значение строки: m = ");
    int numM = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Укажите значение столбца: n = ");
    int numN = Convert.ToInt32(Console.ReadLine()) -1;

    if (numM < 0 || numN < 0) Console.Write("Неверно заданы значения");
    else if (numM >= matrix.GetLength(0) || numN >= matrix.GetLength(1))
        Console.WriteLine("Такого элемента не существует!");

    else Console.WriteLine($"Значение заданного элемента -> {matrix[numM, numN]}");
}