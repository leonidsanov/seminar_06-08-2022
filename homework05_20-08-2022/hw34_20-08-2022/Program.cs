// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива:  ");

int size = Convert.ToInt32(Console.ReadLine()); // вводим число, означающее размер массива

int[] numbers = new int[size]; // создаём новый массив

FillArrayRandomNumbers(numbers); // заполняем массив с помощью функции заполнения

Console.WriteLine("Массив: "); // выводим в терминале сам массив

PrintArray(numbers);

int count = 0;

// подсчитываем количество чётных
for (int j = 0; j < numbers.Length; j++)
    if (numbers[j] % 2 == 0)
        count++;

Console.WriteLine($"Всего {numbers.Length} чисел, из них чётных {count}");

// функция заполнения массива
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 999);
    }
}

// функция вывода массива на печать в терминале
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}