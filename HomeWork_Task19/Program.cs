// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int reversNumber = reverseDigits(number);

if (reversNumber == number) Console.WriteLine($"{number} - является палиндромом!");
else Console.WriteLine($"{number} - не является полиндромом!");

int reverseDigits(int num)
{
    int reversNum = default;
    while (num > 0)
    {
        reversNum = reversNum * 10 + num % 10;
        num = num / 10;
    }
    return reversNum;
}
