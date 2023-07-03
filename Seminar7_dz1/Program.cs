// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray2D(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(numbers[i, j],2);
            System.Console.Write($"{(numbers[i, j])}\t");
        }
        System.Console.WriteLine();
    }
}

double[,] GenerateArray2D(int rows, int columns)
{
    double[,] numbers = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            int check = rnd.Next(1, 2);
            {
                numbers[i, j] = -5 + (Math.Round(rnd.NextDouble(), 2)) * 10;
            }
        }
    }
    return numbers;
}

double[,] newArray = GenerateArray2D(3, 4);
PrintArray2D(newArray);
