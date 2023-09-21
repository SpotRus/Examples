int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 23;
int c1 = 56;
int a2 = 12;
int b2 = 76;
int c2 = 67;
int a3 = 73;
int b3 = 34;
int c3 = 11;

// int max1 = max(a1, b1, c1);
// int max2 = max(a2, b2, c2);
// int max3 = max(a3, b3, c3);
// int lastMax = max(max1, max2, max3);

int lastMax = max(max(a1, b1, c1), max(a2, b2, c2), max(a3, b3, c3));

Console.Write(lastMax);