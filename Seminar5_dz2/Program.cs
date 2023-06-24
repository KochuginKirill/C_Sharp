// Задайте одномерный массив,
//заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

int CountSum(int[] input)
    {
        if(input == null)                 // данный цикл позволяет проверить нет ли null во входящем значении
        {                                 
            return 0;                     // Возвращает 0
        }                                 // Я просто очень хотел разобраться как с null бороться
              
        int countSum = input.Where(n => n % 2 == 1).Sum(); // Where ищет в соответствии с условием после => и складывает в Sum()
                                                           // Страраюсь практиковаться в .Count .Where . Sum()
        return countSum;                                   // Понимаю что здесь можно было просто циклом решить
    }



int[] newArray = GenerateArray(5, 1, 10);
PrintArray(newArray);
Console.WriteLine();
int result = CountSum(newArray);
Console.WriteLine($"сумма нечетных чисел в массиве равно: {result}");