// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число от 100 до 1000: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);

int SecondDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}

if (number > 99 && number < 1000)
    Console.WriteLine($"Вторая цифра числа {number} => {result}");

else Console.WriteLine("Введено некорректное число!");

 