int ReadInt(string message)
{
    Console.WriteLine(" ");
    int value = Convert.ToInt32(Console.Readline());
    return value;
}

bool Validate3sigh (int number)
{
    if(number >=100 && number < 1000)
    {
        return true;
    }
    Console.WriteLine("Число не трехзначное");
    return false;
}

int num = ReadInt("Введите число > ");
if (Validate3sign(num))
{
    int lastDigit = num % 10;
    Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
}