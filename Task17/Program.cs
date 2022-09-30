// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.WriteLine("Введите координаты точки ");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
Console.WriteLine(quarter == 0 ? "Введены некоректные координаты" : quarter);

string quarterStr = QuarterStr(xC, yC); 
Console.WriteLine(quarterStr);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

string QuarterStr(int x, int y)
{
    if (x > 0 && y > 0) return "Первая четверть";
    if (x < 0 && y > 0) return "Вторая четверть";
    if (x < 0 && y < 0) return "Третья четверть";
    if (x > 0 && y < 0) return "Четвертая четверть";
    return "Введены некоректные координаты";
}