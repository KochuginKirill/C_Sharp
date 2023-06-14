//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое трехзначное число");

number = number / 10;
number = number % 10;

Console.WriteLine($"Вторая цифра: {number}");
