// Напишите программу, 
//которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник 
//с сторонами такой длины.

int CheckInt(string message)
{
    System.Console.Write($"{message} > ");
    string InputStr = Console.ReadLine()!;
    int value;
    if (int.TryParse(InputStr, out value))
    {
        return value;
    }
    Console.WriteLine("Извините, но вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}

int x = CheckInt("Напишите первую сторону");
int y = CheckInt("Теперь вторую");
int z = CheckInt("И третью заодно");



void CheckTriangle(string message)
{
    if(x + y !< z || y + z !< x || z + x !< y)
    {
        Console.WriteLine("Извините, треугольника не выйдет");
        Environment.Exit(0);
    }
    if(x * x + y * y == z * z || y * y + z* z == x * x || z* z + x * x == y * y)
    {
        Console.WriteLine("Будет прямоугольный треугольник");
    }
    else
    {
    Console.WriteLine("Будет не прямоугольный треугольник");
    }
}

CheckTriangle("тругольник");
