// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив: 1 4 7 2 
                        //5 9 2 3
                        //8 4 2 4


int Enter(string message)
{
    int n;
        Console.WriteLine($"Please enter the number of the {message}: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {Console.WriteLine("It's not number! Please enter number!");}
    return n;
} 

void FillArray(int[,] numbers)
{
Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = rnd.Next(-9, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
   for (int i = 0; i < numbers.GetLength(0); i++) 
   { 
        for (int j = 0; j < numbers.GetLength(1); j++) 
        { 
            Console.Write($"{numbers[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
}

void Checking(int[,] numbers)
{
 int str = Enter("strings");
 int tab = Enter("tables");
    if (str <= numbers.GetLength(0) && tab <= numbers.GetLength(1))
        {Console.WriteLine($"The value of the given array element {numbers[str, tab]} ");}
    else 
        {Console.WriteLine($"There is no such cell in the array!");}
}

void Task050()
{
 int[,] numbers = new int[3, 4];
 FillArray(numbers);
 Checking(numbers);
 Console.WriteLine();
 PrintArray(numbers);
}

Task050();
