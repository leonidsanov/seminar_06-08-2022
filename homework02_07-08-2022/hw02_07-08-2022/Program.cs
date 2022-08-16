// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
// вводим число. Т.к. метод Console.ReadLine() возвращает строку пишем string
string? Number = Console.ReadLine();
if (Number!.Length > 2)
{
    Console.WriteLine("третья цифра: " + Number[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}