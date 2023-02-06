//Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine($"Максимальное число {max}");
