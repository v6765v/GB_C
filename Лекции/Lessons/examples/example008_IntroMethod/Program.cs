﻿// Поиск максимума из 9 чисел (вручную)

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if ( arg2 > result ) result = arg2;
    if ( arg3 > result ) result = arg3;
    return result;
}


int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 138942;
int b3 = 2380;
int c3 = 3138;


// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);


int max = Max(
          Max(a1, b1, c1), 
          Max(a2, b2, c2), 
          Max(a3, b3, c3));



System.Console.WriteLine(max);