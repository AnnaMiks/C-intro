// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max1 = a;
int max2 = b;

if (b > a)
{
    max1 = b;
}
else
{
    max1 = a;
}
if (c > b)
{
    max2 = c;
}
else
{
    max2 = b;
}
int result = max1;
if (max1 > max2)
{
    result = max1;
}
else
{
    result = max2;
}
Console.WriteLine("Максимальное число : " + result);
