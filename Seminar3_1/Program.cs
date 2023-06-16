int ReadInt(string message)
{
    Console.Write($"{message} >");
    int value = int.Rarse(Console.ReadLine());
    return value;
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console>writeLine("одна из координат ровна нулю");
        return false;
    }
    return true;
}

