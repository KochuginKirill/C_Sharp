// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int CountNumb(int[] input)
    {
        if(input == null)                 // данный цикл позволяет проверить нет ли null во входящем значении
        {                                 
            return 0;                     // Возвращает 0
        }                                 // Я просто очень хотел разобраться как с null бороться
              
        int countNumber = input.Count(n => n % 2 == 0); // Count ведет счетчик в соответствии с условием после =>
                                                        // Страраюсь практиковаться в .Count .Where . Sum()
        return countNumber;                             // Понимаю что здесь можно было просто циклом решить можно
    }



int[] newArray = GenerateArray(10, 100, 999);
PrintArray(newArray);
Console.WriteLine();
int result = CountNumb(newArray);
Console.WriteLine($"число четных чисел в массиве равно: {result}");



