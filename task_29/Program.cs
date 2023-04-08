// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


using System;
class Program 
{ 
    static void Main(string[] args) 
    { 
        int[] arr = new int[8]; 

        for (int i = 0; i < arr.Length; i++) 
        { 
            arr[i] = GetInput($"Введите {i+1}-й элемент массива: "); 
        } 
        
        PrintArray(arr); 
    } 

static int GetInput(string prompt)  
    { 
        Console.Write(prompt); 
        return int.Parse(Console.ReadLine()); 
    }

static void PrintArray(int[] arr) 
    { 
    Console.WriteLine("Массив:"); 

     for (int i = 0; i < arr.Length; i++) 
     { 
        Console.Write(arr[i] + " "); 
     } 
    }   
} 