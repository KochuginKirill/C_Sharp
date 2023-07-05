// Задача 4: * 
// Напишите программу, 
// которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GenerateSpiralArray2D(int size)
{
    int[,] matrix = new int[size, size];
    int startSize = 0;
    int currentCount = 1;
        while (size > 0)
        {
            for (int i = startSize; i <= startSize + size - 1; i++)
            {
                matrix[startSize, i] = currentCount++;
            }
            for (int j = startSize + 1; j <= startSize + size - 1; j++)
            {
                matrix[j, startSize + size - 1] = currentCount++;
            }
            for (int i = startSize + size - 2; i >= startSize; i--)
            {
                matrix[startSize + size - 1, i] = currentCount++;
            }
            for (int i = startSize + size - 2; i >= startSize + 1; i--)
            {
                matrix[i, startSize] = currentCount++;
            }
            startSize += 1;
            size = size - 2;
        }
    return matrix;
}

int size = ReadInt("Введите размер матрицы => ");
int[,] newArray = GenerateSpiralArray2D(size);
PrintArray2D(newArray);