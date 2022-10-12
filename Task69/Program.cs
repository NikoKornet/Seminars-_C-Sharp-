// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
int powAtoB = PutAInPowerB (numberA, numberB);
Console.WriteLine(powAtoB);


int PutAInPowerB(int numA, int numB)  
{
    return numB == 0 ? 1: numA * PutAInPowerB(numA, numB - 1); 
}