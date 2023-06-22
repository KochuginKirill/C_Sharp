int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int X1 = ReadInt("Введите координату X1");
int Y1 = ReadInt("Введите координату Y1");
int X2 = ReadInt("Введите координату X2");
int Y2 = ReadInt("Введите координату Y2");

double result = Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2));

Console.WriteLine($"Расстояние между двумя точками равно: {result}");