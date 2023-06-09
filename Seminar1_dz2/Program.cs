Console.WriteLine("Напишите первое целое положительное число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе целое положительное число");
string input_string2 = Console.ReadLine();
Console.WriteLine("Напишите третье целое положительное число");
string input_string3 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
int number3 = Convert.ToInt32(input_string3);
int max1 = number1;
int max2 = 0;
int max3 = 0;
if (number2 > max1)
{
   max1 = number2;
   max2 = number1;
}
else 
{
    number2 = max2;
}

if (number3 > max1)
{
    max3 = max2;
    max2 = max1;
    max1 = number3;
}

else
{
    if (number3 > max2)
    {
    max3 = max2;
    max2 = number3;
    }
    else
    {
        max3 = number3;
    }
}

Console.WriteLine($"Первое максимальное число, которое является ответом на задачу, равно: {max1}");

// Это просто для себя сделал, чтобы проверить 

Console.WriteLine($"Второе максимальное число равно: {max2}");
Console.WriteLine($"Наименьшее число равно: {max3}");