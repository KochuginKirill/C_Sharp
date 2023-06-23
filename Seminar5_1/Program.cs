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

int[] CountPositivesSumNegatives(int[] input)
    {
      int minSum = input.Where(x => x > 0).Sum();
      int maxSum = input.Where(x => x < 0).Sum();
      int[] result = {maxSum, minSum};
      return result;
    }

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int[] NewArray = GenerateArray(12, -9, 9);
PrintArray(NewArray);
int[] megaSum = CountPositivesSumNegatives(NewArray);
Console.WriteLine("Суммы равны: ");
PrintArray(megaSum);

