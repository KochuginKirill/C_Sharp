//Напишите программу, 
//которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое число");

if(number > 100)
{
    while(number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра: {number}");
}
else
{
    Console.WriteLine($"Число {number} не содержит третьей цифры");
}