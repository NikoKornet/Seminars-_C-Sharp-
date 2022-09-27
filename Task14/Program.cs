// Задание 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> Нет
// 46 -> Нет
// 161 -> Да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsAliquot(int num1, int num2, int num3)
{
    return num1 % num2 == 0 && num1 % num3 == 0;
}
bool result = IsAliquot(number, 7, 23);
if (result) Console.WriteLine($"{number} кратно одновременно 7 и 23");
else Console.Write($"{number} не кратно 7 и 23");