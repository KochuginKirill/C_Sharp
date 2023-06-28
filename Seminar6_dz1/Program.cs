// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CheckInt(string message)
{
    System.Console.Write($"{message} > ");
    string InputStr = Console.ReadLine()!;
    int value;
    if (int.TryParse(InputStr, out value))
    {
        return value;
    }
    Console.WriteLine("Извините, но вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}

int[] CreateUserNumberArray(string message)
    {
    Console.WriteLine(message);
    int length = CheckInt("Введите количество чисел, которое хотите ввести");
    int[] NewArray = new int[length];
    int index = 0;
    while(index <= length-1)
    {
        NewArray[index] = CheckInt($"Введите {index + 1} число");
        index++;
    }
     int index2 = 0;

    while(index2 <= length-1)
    {
        Console.Write($"{NewArray[index2]} ");
        index2++;
    }
    return NewArray;
    }

    int CountMoreThanZero(int [] array)
    {
        int count = 0;
        for(int index = 0; index < array.Length; index++)
        {
            if(array[index] > 0) count++;
        }
        return count;
    }

int[] userArray = CreateUserNumberArray("Посчитаем количество чисел больше 0");
int result = CountMoreThanZero(userArray);
Console.Write($"=> {result}");
