
    int[] CreateNewArray(string message)
    {
    Console.WriteLine($"Введите число элементов массива");
    string StringInput1 = Console.ReadLine()!;
    int length = Convert.ToInt32(StringInput1);
    int[] NewArray = new int[length];
    int index = 0;
    while(index <= length-1)
    {
        Console.WriteLine($"Напишите {index} элемент массива");
        string StringInput2 = Console.ReadLine()!;
        NewArray[index] = Convert.ToInt32(StringInput2);
        index++;
    }
 Console.WriteLine();
    int index2 = 0;

    while(index2 <= length-1)
    {
        Console.Write($"{NewArray[index2]} ");
        index2++;
    }
    return NewArray;
    }
    int[] superArray = CreateNewArray("Создадим массив");


