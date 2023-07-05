// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
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

int[] MatrixSumRow(int[,] numbers)
{
    int[] result = new int[numbers.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = 0;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i,j];
        }
        Console.WriteLine($"Сумма {i + 1} строки => {sum}");
        result[i] = sum;
    }
    return result;
}

int[] SumMax(int[] sumOfRows)
{
    int[] result = new int[2];
    int max = sumOfRows[0];
    int maxI = 0;
    for (int i = 1; i < sumOfRows.Length; i++)
    {
        if(sumOfRows[i] > max)
        {
            max = sumOfRows[i];
            maxI = i;
        }
    }
    result[0] = maxI + 1;
    result[1] = max;
    return result;
}

int rows = ReadInt("Введите число строк => ");
int columns = ReadInt("Введите число столбцов => ");
int[,] newArray = GenerateArray2D(rows,columns);
PrintArray2D(newArray);
Console.WriteLine();
int[] rowSums = MatrixSumRow(newArray);
Console.WriteLine();
int[] result = SumMax(rowSums);
Console.WriteLine($"Строка {result[0]} имеет наибольшую сумму => {result[1]}");

