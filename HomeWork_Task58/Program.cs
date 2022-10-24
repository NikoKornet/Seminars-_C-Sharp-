// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] arrayOne2D = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(arrayOne2D);
int[,] arrayTwo2D = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(arrayTwo2D);

if (arrayOne2D.GetLength(0) == arrayTwo2D.GetLength(1))
{
    int[,] productTwoMatrices = ProductTwoMatrices(arrayOne2D, arrayTwo2D);
    Console.WriteLine("Результирующая матрица будет: ");
    PrintMatrix(productTwoMatrices);
}
else Console.WriteLine("Умножение матриц невозможно!");


int[,] ProductTwoMatrices(int[,] array1, int[,] array2)
{
    int[,] productMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                productMatrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return productMatrix;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("  |");
    }
    Console.WriteLine();
}