// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
double[] arithmeticMeanElemColumn = ArithmeticMeanElemColumn(array2D);
PrintArrayColumnsMean(arithmeticMeanElemColumn);

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
}

void PrintArrayColumnsMean(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(".");
}

double[] ArithmeticMeanElemColumn(int[,] matrix)
{
    double[] columnsMean = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double meanElemColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            meanElemColumn = meanElemColumn + matrix[j, i];
            columnsMean[i] = Math.Round((Convert.ToDouble(meanElemColumn) / matrix.GetLength(0)), 2);
        }
        
    }
    return columnsMean;
}