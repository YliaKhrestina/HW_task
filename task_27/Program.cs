// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System; 
class Program 
{ static void Main(string[] args) 
 { Console.Write("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = GetSumOfDigits(number); 
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
  } 
 static int GetSumOfDigits(int number) 
 
  { 
    int sum = 0;
     while (number > 0) 
     { 
        sum += number % 10; 
        number /= 10; 
     } return sum; 
 } 
} 