﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите M: ");

int M = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите N: ");

int N = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"M = {M}, N = {N}");

if (M > N)

    for (int i = N; i <= M; i++)

        Console.Write($" {i}");

else

    for (int i = M; i <= N; i++)

        Console.Write($" {i}");