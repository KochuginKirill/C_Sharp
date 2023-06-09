Console.WriteLine("Напишите чичло");
string input_string = Console.ReadLine();
int number = Convert.ToInt32(input_string);
int summ = number * number;
Console.WriteLine($"Квадрат числа {number} равен {summ}");