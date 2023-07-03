// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(-10, 10);
        }
    }
    return numbers;
}

double[] ColumnAvg(int[,] numbers)
{
    double[] result = new double[numbers.GetLength(1)];
    double [] sum = new double[numbers.GetLength(1)];
    double avg = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            sum[i] += numbers[j,i];
        }
        avg = sum[i] / (numbers.GetLength(0));
        result[i] = Math.Round(avg,2);
    }
    return result;
}

int[,] newArray = GenerateArray2D(3,5);
PrintArray2D(newArray);
double[] output = ColumnAvg(newArray);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for(int index = 0; index < output.Length; index++)
{
    Console.Write($" {output[index]}");
}