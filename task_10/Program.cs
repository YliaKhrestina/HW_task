// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int a = 0;
int b = 0;
int SecondNum = 0;
System.Console.WriteLine("Введите трехзначное число: ");
a = int.Parse(Console.ReadLine());
if (a>=100 && a<1000)
{
    b = a / 10;
    SecondNum = b % 10;
    System.Console.Write("Второй цифрой этого числа является ");
    System.Console.WriteLine(SecondNum);

}
else
{
    System.Console.WriteLine("Число некорректное!");
}