// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Дорогой пользователь, введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintFibonacci(number);

// void PrintFibonacci(int num)
// {
//     int firstNum = 0;
//     int secondNum = 1;
    
//     Console.Write($"{firstNum} {secondNum} ");

//     for (int i = 2; i < num; i++)
//     {
//         int nextNum = firstNum + secondNum;
//         Console.Write($"{nextNum} ");
//         firstNum = secondNum;
//         secondNum = nextNum;
//     }  
// }

// Решение через массив!

int[] array = new int[7];
CreateFibonacciRow(array);
PrintArray(array);

void CreateFibonacciRow(int[] arr)
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
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
