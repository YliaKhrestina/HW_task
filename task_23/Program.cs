// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число N: ");
int n = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Таблица кубов чисел: ");
for (int i = 0; i <= n; i++)
{
    System.Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}