//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine()!);
int b = (a / 10) % 10;
if (a < 100)
{
    Console.WriteLine("Вы ввели число меньше 100");
}
else
{
    Console.WriteLine($"Вторым числом является {b}");
}