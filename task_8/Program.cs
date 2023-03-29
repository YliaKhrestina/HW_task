// Напишите программу, которая на вход принимает число N, а на выход все четные числа от 1 до N

System.Console.WriteLine("Введите число  ");

int a = int.Parse(Console.ReadLine());

for (int i = 2; i <= a; i+=2)
{
    System.Console.Write(i+",");
}
