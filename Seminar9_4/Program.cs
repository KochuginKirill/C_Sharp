// Задача 4: Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int NumberSum (int a, int b)
{
    if(b <= 0)
    {
       return 1; 
    } 
    else 
    {  
       return a * NumberSum(a, b - 1);
    }
}

int result = NumberSum(2, 4);
Console.WriteLine(result);
