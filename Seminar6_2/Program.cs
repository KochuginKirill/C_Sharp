// Напишите программу, 
//которая будет преобразовывать десятичное число 
//в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

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

string DecToBin(int n)
{
    if (n == 0)
    return "0";

    if (n / 2 > 0)
    {
        return DecToBin(n / 2) + (char)(n % 2 + '0');
    }
    else
    {
        return ""+ (char)(n % 2 + '0');
    }
}

int num = CheckInt("Введите число для перевода в двоичную систему из десятичной");
int endResult = Convert.ToInt32(DecToBin(num));
Console.WriteLine();
Console.WriteLine(endResult);