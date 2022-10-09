// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(10, 1, 1000);
PrintArray(arr);
bool checkNumber = CheckNumber(arr, num);
if (checkNumber) Console.WriteLine($"{num} - число присутствует в массиве");
else Console.WriteLine($"{num} - отсутствует в массиве");


int[] CreateArrayRndInt(int size, int min, int max)
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

bool CheckNumber(int[] array, int arg)
{
    bool checkNumber = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            checkNumber = true;
            break;
        }
    }
    return checkNumber;
}    
