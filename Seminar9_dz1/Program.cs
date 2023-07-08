// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет 
// все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void FromMToN (int m, int n)
{
    if(n < m)
    {
       return; 
    } 
    else 
    {
        FromMToN(m, n - 1);
        if(n % 2 == 0)
        {
        Console.Write($"{(n)} ");
        }
    }
}

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int m = ReadInt("Введите число M => ");
int n = ReadInt("Введите число N => ");
FromMToN(m, n);
