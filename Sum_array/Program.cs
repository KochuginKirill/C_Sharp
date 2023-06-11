int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0  1  2  3  4  5  6  7  8
int[] array = {14,23,31,47,85,64,71,83,49};

int index = 0;
int max = array[0];

while (index< 9)
{
int max1 = Max(array[index], array[index + 1], array[index + 2]);
if (max1> max)
{
    max = max1;
}
index = index + 3;
}
Console.WriteLine(max);