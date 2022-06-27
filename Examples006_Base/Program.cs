int a = new Random().Next(1, 10);
int b = new Random().Next(1, 15);
int c = new Random().Next(1, 20);
int d = new Random().Next(1, 40);
int e = new Random().Next(1, 5);

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.WriteLine(max);
