﻿// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 == number2)
    Console.WriteLine("Число 1 равно числу 2");
else
{
    if (number1 > number2)
        Console.WriteLine("Число 1 больше числа 2");
    else
        Console.WriteLine("Число 2 больше числа 1");
}
