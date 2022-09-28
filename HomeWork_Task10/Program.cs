// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число от 100 до 1000: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int thirdDigit = num / 10;
    int secondDigit = thirdDigit % 10;
    return secondDigit;
}

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} => {result}");
 