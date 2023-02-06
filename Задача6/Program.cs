// Напишите программу, которая на вход принимает целое число и выдает, является ли число четным (делится ли оно на два без остатка);

Console.Clear();
Console.WriteLine("Введите число");

int even = int.Parse(Console.ReadLine()!);

if (even % 2 != 0)
{
    Console.WriteLine("Данное число является нечетным");
}
else
{
    Console.WriteLine("Данное число является четным");
}