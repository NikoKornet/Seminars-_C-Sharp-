// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;

if (number1 > max) max = number1;
else (number2 > max) max = number2;

Console.Write($"max = {max}");
// {
//     max = number1;
//     Console.Write($"max = {max}");
// }
// else (number1 < number2);
// {
//     min = number1;
//     Console.Write($"min = {min}");
// }