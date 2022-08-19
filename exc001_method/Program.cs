// max of 9 w/ method

int a1 = 12;
int b1 = 14;
int c1 = 9;
int a2 = 3;
int b2 = 17;
int c2 = 31;
int a3 = 1;
int b3 = 7;
int c3 = 26;

int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (res < arg2) res = arg2;
    if (res < arg3) res = arg3;
    return res;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int maxTotal = Max(max1, max2, max3);

Console.WriteLine("max1 = " + max1);
Console.WriteLine("max2 = " + max2);
Console.WriteLine("max3 = " + max3);
Console.WriteLine("maxTotal = " + maxTotal);