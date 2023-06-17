//Напишите программу, 
//которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int x1 = ReadInt("Введите координату x1");
int y1 = ReadInt("Введите координату y1");
int z1 = ReadInt("Введите координату z1");
int x2 = ReadInt("Введите координату x2");
int y2 = ReadInt("Введите координату y2");
int z2 = ReadInt("Введите координату z2");

double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + + Math.Pow((z2-z1),2));

Console.WriteLine($"Расстояние между двумя точками равно: {result}");
