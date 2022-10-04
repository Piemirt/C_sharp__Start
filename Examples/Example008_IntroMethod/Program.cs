Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result)
        result = arg2;
    if(arg3 > result)
        result = arg3;
    return result;
}

int a1 = 3;
int b1 = 31;
int c1 = 13;
int a2 = 2;
int b2 = 21;
int c2 = 12;
int a3 = 100;
int b3 = 17;
int c3 = 11;

int max = Max(Max(a1, b1, c1),
              Max(a2, b2, c2),
              Max(a3, b3, c3));

Console.WriteLine(max);