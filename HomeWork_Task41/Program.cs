// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите колличество задаваемых чисел M = ");
int numberM = Convert.ToInt32(Console.ReadLine());

int countElemGreaterThanZero = CountElemGreaterThanZero(numberM);

if(countElemGreaterThanZero == 0) Console.Write("Введено число несоответствующее условию");
else Console.Write($"Колличество чисел больше 0 -> {countElemGreaterThanZero}");

int CountElemGreaterThanZero(int size)
{
    int counter = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) counter++;
    }
    return counter;
}