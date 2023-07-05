// Задача 1: 
// Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочивает по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] RowSorting(int[,] numbers)
{
    int max = numbers[0,0];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for(int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if(numbers[i, k] < numbers[i, k + 1])
                {
                int temp = numbers[i, k];
                numbers[i, k] = numbers[i, k + 1];
                numbers[i, k + 1] = temp;
                }
            }
        }
    }
    return numbers;
}

int rows = ReadInt("Введите число строк => ");
int columns = ReadInt("Введите число столбцов => ");
int[,] newArray = GenerateArray2D(rows,columns);
PrintArray2D(newArray);
Console.WriteLine();
int[,] resultArray = RowSorting(newArray);
PrintArray2D(resultArray);