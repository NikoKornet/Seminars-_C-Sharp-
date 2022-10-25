// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());


if (numberM == numberN) Console.Write($"Числа равны!");
else
{
    if (numberM > numberN)
    {
        int temp = numberM;
        numberM = numberN;
        numberN = temp;
    }
    int digitSumNumber = DigitSumNumber(numberM, numberN);
    Console.Write($"Сумма в промежутке от M до N -> {digitSumNumber} ");
}

int DigitSumNumber(int numM, int numN)
{
    int sumNumber = numN;
    if (numM < numN)
    {
        sumNumber += DigitSumNumber(numM, numN - 1);
    }
    return sumNumber;
}



