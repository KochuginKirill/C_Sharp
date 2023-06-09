Console.WriteLine("Напишите целое положительное число");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int result = 2;
while (result <= number1)
{
   Console.Write($"{result} ");
   result += 2;
}


