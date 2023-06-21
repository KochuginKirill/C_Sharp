int CheckInt(string message)
{
    System.Console.Write($"{message} > ");
    string InputStr = Console.ReadLine();
    int value;
    if (int.TryParse(InputStr, out value))
    {
        return value;
    }
    Console.WriteLine("Извините, но вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}

int len(int number)
{
     int count = 0;
    for(int check = number; check > 0; count++)
    {
        check = check / 10;
    }
    return count;
}

int SumNumb(int NumberCount, int NewNumber)
{
    int sum = 0;
    for(int index = 0; index < NumberCount; index++)
    {
        sum = sum + NewNumber % 10;
        NewNumber = NewNumber / 10;    
    }
    return sum;
}

int NewNumber = CheckInt("Введите целое положительное число");
int CountNumber = len(NewNumber);
int result = SumNumb(CountNumber, NewNumber);
Console.WriteLine($"сумма цифр числа {NewNumber} равняется {result}");


