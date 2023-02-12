/*Task4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 */

Console.WriteLine("Введите 3 числа: ");
int a, b, c;
Console.Write("Ведите a = ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите b = ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите c = ");
int.TryParse(Console.ReadLine()!, out c);
int max = a;
if (b > a)
    max = b;
if (c > a)
    max = c;
Console.WriteLine($"max = {max}");