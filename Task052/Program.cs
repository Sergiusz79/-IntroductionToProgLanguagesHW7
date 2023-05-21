// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(double[,] numbers)
{
Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = rnd.Next(1, 11);
        }
    }
}

void PrintArray(double[,] numbers)
{
   for (int i = 0; i < numbers.GetLength(0); i++) 
   { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.Write($"{numbers[i, j]}  "); 
        } 
        Console.WriteLine(); 
    } 
}

void Average (double[,] array)
{
 double[] av = new double[array.GetLength(1)];

   for (int j = 0; j < array.GetLength(1); j++) 
   { 
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        { 
            sum += array[i, j];
        }
        av[j] = Math.Round(sum/array.GetLength(0), 2); 
        Console.Write($"{av[j]}  "); 
    } 
 Console.WriteLine(); 
}

void Task052()
{
 double[,] numbers = new double[3, 4];
 double[] av = new double[numbers.GetLength(0)];
 FillArray(numbers);
 Average(numbers);
 Console.WriteLine();
 PrintArray(numbers);
}

Task052();



