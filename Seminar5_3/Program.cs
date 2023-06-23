// Задача 2: Задайте массив. Напишите программу, 
//которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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

bool NumbSearch(int[] arrayInput)
{
    int nuberSearch = 4;
    for(int index = 0; index < arrayInput.Length; index++)
    {
        if(arrayInput[index] == nuberSearch) 
        {
            return true;
        }    
    }
    return false;
}

int[] newArray = GenerateArray(10, -10, 10);
PrintArray(newArray);
Console.WriteLine();
bool check = NumbSearch(newArray);
if(check == true)
{
    Console.WriteLine("Такое число есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}