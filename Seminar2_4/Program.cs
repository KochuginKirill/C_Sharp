//Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое число");

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"{number} не кратно 7 и 23");
}