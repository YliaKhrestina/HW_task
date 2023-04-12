//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



int[] arrayOfNumbers = { 3, 7, 22, 2, 78 };
            int max = arrayOfNumbers[0];
            int min = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > max)
                {
                    max = arrayOfNumbers[i];
                }
                else if (arrayOfNumbers[i] < min)
                {
                    min = arrayOfNumbers[i];
                }
            }
            int differenceBetweenMinMaxNumbers = max - min;
            Console.WriteLine($"Минимальное значение в массиве: {min} Максимальное значение в массиве: {max} Разница между максимальным и минимальным элементов массива ровняется: {differenceBetweenMinMaxNumbers}");
            