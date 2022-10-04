int a1 = 3;
int b1 = 31;
int c1 = 13;
int a2 = 2;
int b2 = 21;
int c2 = 12;
int a3 = 1;
int b3 = 17;
int c3 = 11;

int max = a1;

if(b1 > max)
    max = b1;
if(c1 > max)
    max = c1;

if(a2 > max)
    max = a2;
if(b2 > max)
    max = b2;
if(c2 > max)
    max = c2;

if(a3 > max)
    max = a3;
if(b3 > max)
    max = b3;
if(c3 > max)
    max = c3;

Console.WriteLine(max);