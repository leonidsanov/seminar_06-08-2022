// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
// метод Console.ReadLine() всегда возвращает тип string
// при этом строка является массивом. Поэтому:
string threeDigitNumber = Console.ReadLine();
Console.WriteLine(threeDigitNumber[1]);