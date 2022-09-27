// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
int RemoveSecondDigit(int num)
{
    int thirdDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + thirdDigit;
} 

int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");
 