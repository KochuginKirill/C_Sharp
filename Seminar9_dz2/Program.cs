// Задача 2: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int FromMToN (int m, int n, int sum = 0)
{
    if(n < m)
    {
       return sum; 
    } 
    else 
    {
        return FromMToN(m, n - 1, sum += n);
    }
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int m = ReadInt("Введите число M => ");
int n = ReadInt("Введите число N => ");
int result = FromMToN(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке: {result}");
