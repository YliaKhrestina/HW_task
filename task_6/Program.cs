// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на 2 без остатка)

System.Console.WriteLine("Введите число  ");

int a = int.Parse(Console.ReadLine());
if (a%2 == 0)
{
    System.Console.WriteLine("четное");
}
else
{
    System.Console.WriteLine("нечетное");
}