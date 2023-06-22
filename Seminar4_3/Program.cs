//Задача 2: Напишите программу, 
//которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int ReadInt(string message)
{
    Console.WriteLine(message);
    string ReadString = Console.ReadLine()!;
    int number = Convert.ToInt32(ReadString);
    return number;
}

int Factorial(int number)
{
    int index = 1;
    int fact = 1;
    while(index <= number)
    {
        fact = fact * index;
        index++;
    }
    return fact;
}

int NewNumber = ReadInt("Введите целое положительное число");
int result = Factorial(NewNumber);
Console.WriteLine(result);