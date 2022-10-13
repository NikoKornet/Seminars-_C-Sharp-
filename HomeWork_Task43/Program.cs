// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double valueB1 = Input("b1");
double valueK1 = Input("k1");
double valueB2 = Input("b2");
double valueK2 = Input("k2");

double[] coordinatesXY = PointOfIntersection(valueB1, valueK1, valueB2, valueK2);
OutputCoordinatesIntersection(valueB1, valueK1, valueB2, valueK2);

double Input(string value)
{
    Console.Write($"Задайте значения {value} = ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * (b2 - b1) / (k1 - k2) + b1, 2);
    return new double[] { x, y };
}

void PrintPoint(double[] point)
{
    Console.Write("Точка пересечения прямых (");
    for (int i = 0; i < point.Length; i++)
    {
        if (i < point.Length - 1) Console.Write($"{point[i]}, ");
        else Console.Write($"{point[i]}");
    }
    Console.WriteLine(")");
}

void OutputCoordinatesIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают!");
    else if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны!");
    else PrintPoint(coordinatesXY);

    // Console.Write($"Точка пересечения прямых ({coordinatesXY[0]}"); - можно использовать как другой способ вывода
    // Console.Write($"; {coordinatesXY[1]})");
}

// Андрей, скажите какой способ более приемлем ? Интересно узнать ваше мнение. 
// Я выбрал через метод, мне так показалось как то более привлекательно для кода. И