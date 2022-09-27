// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> Да
// -4, 16 -> Да
// 25,5 -> Да
// 8,9 -> Нет

Console.WriteLine("Введите число :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите другое число :");
int number2 = Convert.ToInt32(Console.ReadLine());

bool SquareNumber (int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

bool result = SquareNumber(number1,number2);
if (result) Console.WriteLine("число является квадратом другого числа");
else Console.Write("число не является квадратом другого числа");
