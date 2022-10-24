// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int[] sumElemeEachRow = SumElemeEachRow(array2D);
PrintArray(sumElemeEachRow);
int smallestSumElem = DefiningRowSmallestSumElem(sumElemeEachRow);
Console.Write($"Строка с наименьшей суммой элементов: {smallestSumElem}");


int[] SumElemeEachRow(int[,] matrix)
{
    int[] rowMean = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElemeRow = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElemeRow = sumElemeRow + matrix[i, j];
        }
        rowMean[i] = sumElemeRow ;
    }
    return rowMean;
}

int DefiningRowSmallestSumElem(int[] arr)
{
    int tempIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < arr[tempIndex]) tempIndex = i;
    }
    return tempIndex;
}

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
        Console.WriteLine("   |");
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Сумма элементов в каждой строке: ");
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{i} -> {arr[i]}. ");
    }
}