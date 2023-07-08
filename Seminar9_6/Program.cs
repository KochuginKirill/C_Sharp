// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”


bool SimpleNumberCheck (int number, int devider = 0)
{
    if(devider == 0)
    {
        devider = number - 1;
    } 
    if(devider == 1)
    {
       return true; 
    } 
    else 
    {  
       return number % devider != 0 && SimpleNumberCheck(number, devider - 1);
    }
}

bool result = SimpleNumberCheck(29);
Console.WriteLine(result);
