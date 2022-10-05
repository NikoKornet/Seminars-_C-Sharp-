// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
    int result = DegreeNumber(number1, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Введено некоректное число!");

int DegreeNumber(int num1, int num2)
{
    int degreeNumber = num1;
    int counter = 1;
    while (counter < num2)
    {
        degreeNumber = degreeNumber * num1;
        counter++;
    }
    return degreeNumber;
}
