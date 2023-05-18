// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9



int Enter(string message)
{
    int n;
        Console.WriteLine($"Please enter the {message} of the array: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {Console.WriteLine("It's not number! Please enter number!");}
    return n;
}    

void FillArray(double[,] numbers)
{
Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
        double d = rnd.Next(-9, 10) + rnd.NextDouble();
        numbers[i, j] = Math.Round(d, 1);
        }
    }
}


void PrintArray(double[,] numbers)
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


void Task047()
{
int strings = Enter("strings");
int tables = Enter("tables");
double[,] numbers = new double[strings, tables];
FillArray(numbers);
PrintArray(numbers);
}


Task047();

