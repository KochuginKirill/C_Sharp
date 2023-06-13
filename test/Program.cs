
    void CreateNewArray(int[] NewArray)
    {
    Console.WriteLine($"Введите число элементов массива");
    string StringInput1 = Console.ReadLine();
    int length = Convert.ToInt32(StringInput1);
    NewArray = new int[length];
    int index = 0;
    while(index <= length-1)
    {
        Console.WriteLine($"Напишите {index} элемент массива");
        string StringInput2 = Console.ReadLine();
        NewArray[index] = Convert.ToInt32(StringInput2);
        index++;
    }

    int index2 = 0;

    while(index2 <= length-1)
    {
        Console.WriteLine($"{index2} элемент массива равен: {NewArray[index2]}");
        index2++;
    }
    }
int[] SuperArray = new int[0];
CreateNewArray(SuperArray);
int[] UltraArray = new int[0];
CreateNewArray(UltraArray);