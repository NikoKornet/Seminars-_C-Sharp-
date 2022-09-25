// Задача 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

// int number = new Random().Next(10, 100);

// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра чила {number} = {secondDigit}");

// int maxDigit = firstDigit;
// if (secondDigit > firstDigit) maxDigit = secondDigit;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine();

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    if (isEqualDigits(firstDigit, secondDigit)) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool isEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра чила {number} = {result}");
