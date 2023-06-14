//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите число дня недели (от 1 до 7)");

if(number <= 7)
{
    if(number == 7 | number ==6)
    Console.WriteLine("Это выходной день");
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}
 else
    {
        Console.WriteLine("Введен не день недели");
    }