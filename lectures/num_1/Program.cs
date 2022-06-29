int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg1 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = new Random().Next(1, 100);
int a2 = new Random().Next(1, 100);
int a3 = new Random().Next(1, 100);
int a4 = new Random().Next(1, 100);
int a5 = new Random().Next(1, 100);
int a6 = new Random().Next(1, 100);
int a7 = new Random().Next(1, 100);
int a8 = new Random().Next(1, 100);
int a9 = new Random().Next(1, 100);

// int max1 = Max(a1, a2, a3);
// int max2 = Max(a4, a5, a6);
// int max3 = Max(a7, a8, a9);
// int max = Max(max1, max2, max3); сокращенный вариант записи на 23 строке.

int max = Max(Max(a1, a2, a3), Max(a4, a5, a6), Max(a7, a8, a9));

Console.WriteLine(max);