int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int n1 = 12;
int n2 = 21;
int n3 = 33;
int n4 = 4;
int n5 = 7;
int n6 = 25;
int n7 = 16;
int n8 = 1;
int n9 = 13;

//int max1 = Max(n1, n2, n3);
//int max2 = Max(n4, n5, n6);
//int max3 = Max(n7, n8, n9);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(n1, n2, n3),
    Max(n4, n5, n6),
    Max(n7, n8, n9));

Console.WriteLine(max);