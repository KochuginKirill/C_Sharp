int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое положительное число");

int index = 1;

while(index <= number)
{
    int result = (index * index);
    Console.Write($"{result} ");
    index++;
}
