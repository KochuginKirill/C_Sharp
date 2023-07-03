// Задача 2. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1

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

int NumberSearchCoordinates(int[,] array, int rows, int columns)
{
    if(rows > array.GetLength(0) | columns > array.GetLength(1))
    {
        Console.WriteLine("Превышен лимить двумерного массива");
        Environment.Exit(0);
    }
    int result = -100;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[rows - 1,columns - 1])
            {
                result = array[i, j];
                return result;
            }
        }
    }
    return result;
}

int[,] newArray = GenerateArray2D(4, 5);
PrintArray2D(newArray);
int output = NumberSearchCoordinates(newArray, ReadInt("Введите ряд (считаем с 1) => "), ReadInt("Введите столбец (считаем с 1) => "));
Console.WriteLine($"Искомое число: {output}");
