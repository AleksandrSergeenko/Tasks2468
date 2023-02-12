﻿/*
Task2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3 

--------------------------------------------------------------------------------------------------------------------
Вариант решения 1:
int a, b;
Console.Write("Ведите a = ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите b = ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
    Console.Write($"max = {a} min = {b}");
if (a < b)
    Console.Write($"max = {b} min = {a}");
--------------------------------------------------------------------------------------------------------------------
*/

//Вариант решения 2:

int a, b;
Console.Write("Ведите a = ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите b = ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
    Console.Write($"max = {a} min = {b}");
else
    Console.Write($"max = {b} min = {a}");

