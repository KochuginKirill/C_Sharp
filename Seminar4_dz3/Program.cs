int CheckInt(string message)
{
    System.Console.Write($"{message} > ");
    string InputStr = Console.ReadLine();
    int value;
    if (int.TryParse(InputStr, out value))
    {
        return value;
    }
    Console.WriteLine("Извините, но вы ввели не целое число");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(string meassage)
{
    Console.WriteLine(meassage);
    int len = CheckInt("Введите число элементов массива");
    int min = CheckInt("Введите минимальную числовую границу элемента массива");
    int max = CheckInt("Введите максимальную числовую границу элемента массива");
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int[] NewArray = GenerateArray("Данная программа поможет вам выбрать число элеметов массива и задать их максимальное и минимальное значение");
PrintArray(NewArray);