// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array2D = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
if (IsMatrixSquare(array2D))
{
    int[,] array2DReplaced = ReplaceRowsToColumns(array2D);
    PrintMatrix(array2DReplaced);
}
else Console.WriteLine("Заменить строки на столбцы не возможно.");
Console.WriteLine();
RewriteRowsToColumns(array2D);
PrintMatrix(array2D);

void RewriteRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temporary;
        }
    }
}

bool IsMatrixSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    // int size = matrix.GetLength(0);
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            replaceMatrix[i, j] = matrix[j, i];
        }
    }
    return replaceMatrix;
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
        Console.WriteLine("|");
    }
}

