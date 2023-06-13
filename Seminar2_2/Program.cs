//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int number1 = new Random().Next(10,99);


int number2 = number1 % 10;

int number3 = number1 / 10;

if(number2 > number3)
{
    Console.WriteLine($" {number2} больше {number3} ");
}
else{
    Console.WriteLine($" {number2} меньше {number3} ");
}