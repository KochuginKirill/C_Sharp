 int[] CreateNewArray(int ArrayLength, int min, int max)
    {
    int length = ArrayLength;
    int[] NewArray = new int[length];
    int index = 0;
    while(index <= length-1)
    {
        Random rnd = new Random();
        NewArray[index] = rnd.Next(min, max);
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
   int[] SuperArray = CreateNewArray(8, 0, 2); 

