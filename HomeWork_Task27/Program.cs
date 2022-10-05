// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 (4 + 5 + 2 = 11)
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumResult = SumResult(Math.Abs(number));
Console.WriteLine(sumResult);


int SumResult(int num)
{
    int sumResult = default;
    int digitsNum = default;
    while (num > 0)
    {
        digitsNum = num % 10;
        num = num / 10;
        sumResult = sumResult + digitsNum;
    }
    return sumResult;
}