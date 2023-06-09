Console.WriteLine("Напишите целое положительное число");
string input_string1 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int result = number1%2;
if (result == 0)
{
   Console.WriteLine($"Число {number1} является четным");
}
else 
{
    Console.WriteLine($"Число {number1} является нечетным");
}

