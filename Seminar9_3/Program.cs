// Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр. 
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int NumberPow (int number)
{
    if(number <= 0)
    {
       return number; 
    } 
    else 
    {  
    return number % 10 + NumberPow(number / 10);
    }
}

int result = NumberPow(131);
Console.WriteLine(result);

