//Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number1 = ReadInt("Введите первое число");
int number2 = ReadInt("Введите второе число");

int result = number1 % number2;

if(result == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
     Console.WriteLine($"Число {number1} не кратно {number2}");
     Console.WriteLine($"Остаток равен {result}");
}