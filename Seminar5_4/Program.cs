// Задача 3: Задайте одномерный массив 
//из 10 случайных чисел 
//в диапазоне от 1 до 200. 
//Найдите количество  двузначных элементов массива. 
//Пример для массива из 5, 
//а не 10 элементов. В своём решении сделайте для 10
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0

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

void PrintArray(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

int doubleSearch(int[] arrayInput)
{
    int count = 0;
    for(int index = 0; index < arrayInput.Length; index++)
    {
        if(arrayInput[index] > 9 & arrayInput[index] < 100) 
        {
            count = count + 1;
        }    
    }
    return(count);
}

int[] newArray = GenerateArray(10, 1, 200);
PrintArray(newArray);
Console.WriteLine();
int count = doubleSearch(newArray);
Console.WriteLine($"Число двухзначных элементов массива равно: {count}");
