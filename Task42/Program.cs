// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

Console.WriteLine("Дорогой пользователь, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int binNum = ConvertNumberToBinary(number);
Console.WriteLine($"{number} -> {binNum}");

int ConvertNumberToBinary(int num)
{
    int binaryNum = default;
    int count = 1;
    while (num > 0)
    {
        binaryNum = binaryNum + num % 2 * count;
        count = count * 10;
        num = num / 2;
    }
    return binaryNum;
}

// Решение через рекурсию
// int number = 13;
DecToBin(number);

void DecToBin(int num)
{
    if (num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2);
}