// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 / 7 / -2 / -0,2

// 1 / -3,3 / 8  / -9,9

// 8 / 7,8 / -7,1 / 9

Console.Write("Введите колличество строк массива: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов массива: n =  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixRndDouble(m, n);
PrintMatrix(array2D);


double[,] CreateMatrixRndDouble(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},   ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}