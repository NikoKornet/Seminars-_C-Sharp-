// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = CreateArrayRndInt(5, 1, 100);
PrintArray(arr);
double differentMaxMinElem = DifferentMaxMinElem(arr);
Console.WriteLine($"{differentMaxMinElem}");

double [] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
    }    
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferentMaxMinElem(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    double diffElem = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxElem) maxElem = array[i];
        else if (array[i] < minElem) minElem = array[i];
    }
    diffElem = maxElem - minElem;
    return diffElem;
}
