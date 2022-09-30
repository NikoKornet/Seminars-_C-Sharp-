// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти в диапозоне от 1 до 4 включительно ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Range(number);
Console.WriteLine(result);

string Range(int num)
{
    if (num == 1) return "Диапазон равен х > 0, у > 0 ";
    if (num == 2) return "Диапазон равен х < 0, у > 0 ";
    if (num == 3) return "Диапазон равен х < 0, у > 0 ";
    if (num == 4) return "Диапазон равен х > 0, у < 0 ";
    return "Введены некорректные данные";
    }