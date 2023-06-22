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



int sqr(int number1, int number2)
{
    int pow = number1;
    if(number2 >= 0)
    {
    if(number1 != 0 & number2 != 0)
    {
    for(int index = 1; index < number2; index++)
    {
        pow = pow * number1;
    }
    }
    else
    {
        if(number2 == 0 & number1 != 0)
        {
             pow = 1;
        }
        else
        {
            pow = 0;
        }
    }
    }
    else
    {
      Console.WriteLine("Введена отрицательная степень, что не подходит для результата в целых числах");
      Environment.Exit(0);
    }

    return pow;
}

int a = CheckInt("Введите целое число");
int b = CheckInt("Введите натуральное число для значения степени");
int result = sqr(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");