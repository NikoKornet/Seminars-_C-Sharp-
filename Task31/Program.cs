// Задача 31.
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод результата.

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

int [] GetSumPositivNegativElem(int[] array)
{
    int sumPositiv = default;
    int sumNegativ = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNegativ += array[i]; // sumNegativ = sumNegativ + array[i]
        else sumPositiv += array[i]; //sumPositiv = sumPosinive + array[i];
    }
    return new int[] {sumPositiv, sumNegativ};
}
int[] arr = CreateArrayRndInt(12, -9, 9); // Задаем любые параметры массива
PrintArray(arr);
int [] getSumPositivNegativElem = GetSumPositivNegativElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositivNegativElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositivNegativElem[1]}");
