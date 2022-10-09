// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = CreateArrayRndInt(6, -10, 10);
PrintArray(arr);
int getSumNegativElem = GetSumNegativElem(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях => {getSumNegativElem}");


int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int GetSumNegativElem(int[] array)
{
    int sumNegativ = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) sumNegativ += array[i]; 
    }
    return sumNegativ;
}