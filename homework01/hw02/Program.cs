// Задача 4: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = 22;
int b = 3;
int c = 9;

int maximum = a;

if (maximum > b)
{
    maximum = a;
    if (maximum > c)
    {
        maximum = a;
    }
    else
    {
        maximum = c;
    }
}
else
{
    maximum = b;
    if (maximum > c)
    {
        maximum = b;
    }
    else
    {
        maximum = c;
    }
}
Console.WriteLine(maximum);