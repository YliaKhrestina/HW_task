// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int a = 0;
int ThirdNum = 0;

System.Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine());


{
    while (a >999)
    {
    ThirdNum = a / 10 % 10;
    System.Console.Write("Третьей цифрой этого числа является ");
    System.Console.WriteLine(ThirdNum);
    }
    
    if (a < 100)
    {
    System.Console.WriteLine("Третьей цифры числа нет!");
    }
}  
