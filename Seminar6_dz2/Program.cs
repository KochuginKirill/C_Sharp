// Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

void FindDot(string message)
{
    Console.WriteLine(message);
    double b1 = CheckInt("Введите b1");
    double k1 = CheckInt("Введите k1");
    double b2 = CheckInt("Введите b2");
    double k2 = CheckInt("Введите k2");
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечиния: {x} {y}");
}
FindDot("Найдем точку пересечения двух прямых");