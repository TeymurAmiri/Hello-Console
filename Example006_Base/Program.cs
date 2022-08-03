int a = 10;
int b = 21;
int c = 16;
int d = 22;
int e = 42;
int max = a;

if( a > max ) max = a;
if( b > max ) max = b;
if( c > max ) max = c;
if( d > max ) max = d;
if( e > max ) max = e;
Console.Write("Максимальное значение: ");
Console.Write(max);