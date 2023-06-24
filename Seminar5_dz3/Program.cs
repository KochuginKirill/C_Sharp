//  Задайте массив вещественных чисел. 
//Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void PrintArray(double[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

double [] GenerateArray(int len, double min, double max)
{
    double[] list1 = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = min + rnd.NextDouble() * max + 1; // Всеми способами пытался сократить число дробных знаков, но вышло не во всех числах, похоже перегрузка типа переменной
    }
    return list1;
}

double CountSumMinMax(double[] input)
    {
        if(input == null)                 // данный цикл позволяет проверить нет ли null во входящем значении
        {                                 
            return 0;                     // Возвращает 0
        }                                 // Я просто очень хотел разобраться как с null бороться

        //double min = input.Min(); более простой способ
       //double max = input.Max(); 
       double min = input[0];
       double max = input[0];

       for(int indexMin = 0; indexMin < input.Length; indexMin++)
       {
        if(input[indexMin] < min)
        {
            min = input[indexMin];
        }
       }

       for(int indexMax = 0; indexMax < input.Length; indexMax++)
       {
        if(input[indexMax] > max)
        {
            max = input[indexMax];
        }
       }
              
        double countSum = min + max;                        
                                                              
        return countSum;                                 
    }


double[] newArray = GenerateArray(5, 1, 100);
PrintArray(newArray);
Console.WriteLine();
double result = CountSumMinMax(newArray);
Console.WriteLine($"сумма минимального и максимального значения числел массива равна: {result}");
