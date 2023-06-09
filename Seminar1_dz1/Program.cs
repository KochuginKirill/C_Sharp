Console.WriteLine("Напишите первое целое положительное число");
string input_string1 = Console.ReadLine();
Console.WriteLine("Напишите второе целое положительное число");
string input_string2 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
if (number2 < number1)
{
      Console.Write($"min = {number2} max = {number1}");
}
if (number2 > number1)
{
      Console.Write($"max = {number2} min = {number1}");
}
if (number2 == number1)
{
      Console.Write($"{number2} = {number1}");
}