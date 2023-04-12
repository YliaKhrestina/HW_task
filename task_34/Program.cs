// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


 int[] GenerateRandomArray(int length, int min, int max)
 {
     Random rnd = new Random();
    int[] arr = new int[length];
     for (int i = 0; i < length; i++)
     {       
        arr[i] = rnd.Next(min, max); 
        Console.Write($" { arr[i] }  ");
        
     }
    return arr;
 }

int Numbers(int[] arr)
{ 
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = GenerateRandomArray(5,100,999);
int Count = Numbers(arr);
System.Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {Count}");
