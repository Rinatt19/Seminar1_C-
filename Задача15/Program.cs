//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число от 1 до 7 включительно:");
int day = int.Parse(Console.ReadLine()!);
if (day = 1 && day < 6)
{
    Console.WriteLine("Является рабочим днем!");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Является выходным днем!");
}