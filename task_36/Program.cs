// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


     int[] GenerateRandomArray(int length, int min, int max)
     {
             Random rnd = new Random();
             int[] arr = new int[length];
             for (int i = 0; i < length; i++)
             {      
                arr[i] = rnd.Next(min, max); 
                System.Console.Write($" { arr[i] }  ");
                System.Console.Write($"-{i}-  ");
             }
            return arr;
     }

     
int SumElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
 
}


int[] arr = GenerateRandomArray(4,1,10);
int sum = SumElements(arr);
System.Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);



// void Main(string[] args)
//     {
//         // Задаём массив с случайными числами
//         int[] numbers = { 3, 7, 23, 12 };

//         // Инициализируем переменную для хранения суммы
//         int sum = 0;

//         // Проходим по элементам массива и суммируем элементы с нечётными индексами
//         for (int i = 1; i < numbers.Length; i += 2)
//         {
//             sum += numbers[i];
//         }

//         // Выводим результат
//         Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
//     }



