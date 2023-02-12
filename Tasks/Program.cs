/*Task6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

int N;
Console.Write("Число чётное? Ведите число: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (flag)
{
    if (N % 2 == 0)
        Console.Write($"{N} -> да");  
    else
        Console.Write($"{N} -> нет");
}
else
    Console.Write("Неверный ввод");