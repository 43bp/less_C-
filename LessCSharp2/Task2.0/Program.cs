// Найти максимальное из 9 чисел
int Max(int arg1, int arg2, int arg3) // пишем метод поиска максимума из трех
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}

int a1 = 15;
int a2 = 55;
int a3 = 12;
int a4 = 13;
int a5 = 2;
int a6 = -2;
int a7 = 0;
int a8 = 65;
int a9 = 12;

int max1 = Max(a1, a2, a3);   // сравниваем спомощью нашего метода по три числа
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);  // потом из тройки ищем максимальное
// а можно и так:
// int max = Max(Max(a1, a2, a3),Max(a4, a5, a6),Max(a7, a8, a9))

Console.WriteLine(max);