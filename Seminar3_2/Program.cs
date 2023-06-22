//Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
int ReadInt(string message)
{
    System.Console.WriteLine($"{message} >");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

bool VaidateCords(int x)
{
    if (x <= 0 || x > 4)
    {
        System.Console.WriteLine("Вы ввели значение равной 0");
        return false;
    }
    return true;
}

string GetQuorterNumber(int x)
{
    string message = "";
    if (x == 1)
    {
        message = "Диапазон первой четверти от 1 до N по X и от 1 до N по Y";
    }
    if (x == 2)
    {
        message = "Диапазон первой четверти от -1 до -N по X и от 1 до N по Y";
    }
    if (x == 3)
    {
        message = "Диапазон первой четверти от -1 до -N по X и от -1 до -N по Y";
    }
    if (x == 4)
    {
        message = "Диапазон первой четверти от 1 до N по X и от -1 до -N по Y";
    }

    return message;
}

int x = ReadInt("Введите координату Х > ");

if (VaidateCords(x))
{
    System.Console.WriteLine($"{GetQuorterNumber(x)}");
}




