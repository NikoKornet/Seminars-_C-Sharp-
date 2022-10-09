// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = CreateArrayRndPositivThreeDig(10, 100, 1000);
PrintArray(arr);
int quantityEvenElem = QuantityEvenElem(arr);
Console.WriteLine($"Колличество четных чисел = {quantityEvenElem}");

int[] CreateArrayRndPositivThreeDig(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int QuantityEvenElem(int[] array)
{
    int evenElem = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenElem++; 
    }    
    return evenElem;
}