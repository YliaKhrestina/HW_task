// Напишите программу, которая на вход принимает 3 числа и выводит максимальное

System.Console.WriteLine("Введите число  ");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;

System.Console.Write("max = ");
System.Console.Write(max);