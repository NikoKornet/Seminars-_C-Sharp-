// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void CubeTable(int number)
{
    int counter = 1;
    while (counter <= num)
    {
        Console.WriteLine($"|{counter, 3} | {counter * counter * counter, 5} |");
        counter++;
    }
}
if (num >0) CubeTable(num);
else Console.WriteLine("Введено некорректное число");