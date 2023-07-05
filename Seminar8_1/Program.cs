// Задача 1: Задайте двумерный массив. 
// Напишите программу, 
// которая поменяет местами 
// первую и последнюю строку массива.

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

int[,] RowChange(int[,] numbers)
{
    int temp = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        temp = numbers[0,i];
        numbers[0,i] = numbers[numbers.GetLength(0) - 1,i];
        numbers[numbers.GetLength(0) - 1,i] = temp;
    }
    return numbers;
}

int rows = ReadInt("Введите число строк => ");
int columns = ReadInt("Введите число столбцов => ");
int[,] newArray = GenerateArray2D(rows,columns);
PrintArray2D(newArray);
Console.WriteLine();
int[,] resultArray = RowChange(newArray);
PrintArray2D(resultArray);