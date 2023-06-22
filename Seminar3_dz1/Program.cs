//Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int number = ReadInt("Введите целое пятизначное число");
if((number % 10) == (number / 10000) & ((number / 10) % 10) == (number % 10000) / 1000)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
