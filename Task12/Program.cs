// Задание 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool CheckMultiplicity(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}
if (CheckMultiplicity(number1,number2)) Console.WriteLine($"{number1} кратно {number2}");
else Console.Write($"{number1} не кратно {number2}! Остаток: {number1 % number2}");
