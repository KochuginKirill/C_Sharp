Console.WriteLine("Напишите день недели в виде целого числа день недели");
string input_string1 = Console.ReadLine()!;
int number1 = Convert.ToInt32(input_string1);
if (number1 == 1)
{
    Console.WriteLine($"{number1} - это понедельник!");
}
if (number1 == 2)
{
    Console.WriteLine($"{number1} - это вторник!");
}
if (number1 == 3)
{
    Console.WriteLine($"{number1} - это среда!");
}
if (number1 == 4)
{
    Console.WriteLine($"{number1} - это четверг!");
}
if (number1 == 5)
{
    Console.WriteLine($"{number1} - это пятница!");
}
if (number1 == 6)
{
    Console.WriteLine($"{number1} - это суббота!");
}
if (number1 == 7)
{
    Console.WriteLine($"{number1} - это воскресенье!");
}
if (number1 > 7)
{
    Console.WriteLine($"Не тот день!");
}
if (number1 < 1)
{
    Console.WriteLine($"Не тот день!");
}