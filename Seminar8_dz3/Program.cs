// Задача 3: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

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

int[,] Array2DMulti(int[,] numbersFirst, int[,] numbersSecond)
{
    if (numbersFirst.GetLength(1) != numbersSecond.GetLength(0))
    {
        Console.WriteLine("Такие матрицы не умножить друг на друга");
        Environment.Exit(0);
    }
    int[,] result = new int[numbersFirst.GetLength(0), numbersSecond.GetLength(1)];
    for (int i = 0; i < numbersFirst.GetLength(0); i++)
    {
        for(int j = 0; j < numbersSecond.GetLength(1); j++)
        {
            for(int k = 0; k < numbersSecond.GetLength(0); k++)
            {
                result[i,j] += numbersFirst[i,k] * numbersSecond[k,j];
            }
        }
    }
    return result;
}

int rowsFirst = ReadInt("Введите число строк первой матрицы => ");
int columnsFirst = ReadInt("Введите число столбцов первой матрицы => ");
int[,] newArrayFirst = GenerateArray2D(rowsFirst,columnsFirst);
PrintArray2D(newArrayFirst);
int rowsSecond = ReadInt("Введите число строк второй матрицы => ");
int columnsSecond = ReadInt("Введите число столбцов второй матрицы => ");
int[,] newArraySecond = GenerateArray2D(rowsSecond,columnsSecond);
PrintArray2D(newArraySecond);
Console.WriteLine();
int[,] resultArray = Array2DMulti(newArrayFirst, newArraySecond);
Console.WriteLine("Результат умножения: ");
PrintArray2D(resultArray);
