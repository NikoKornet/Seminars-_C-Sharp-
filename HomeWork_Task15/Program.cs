// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number <= 5) Console.WriteLine("Нет, это будний день!");
if (number == 6 || number == 7) Console.Write("Да, это выходной день!");
if (number < 1 || number > 7) Console.WriteLine("Введено некорректное число!");