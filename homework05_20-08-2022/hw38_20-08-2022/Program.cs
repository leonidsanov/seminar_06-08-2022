// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива:  ");

int size = Convert.ToInt32(Console.ReadLine()); // вводим число, означающее размер массива

int[] numbers = new int[size]; // создаём новый массив

FillArrayRandomNumbers(numbers); // заполняем массив с помощью функции заполнения

Console.WriteLine("Массив: "); // выводим в терминале сам массив

PrintArray(numbers);

int min = numbers.Min();

int max = numbers.Max();

Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива равна {max - min}");

// функция заполнения массива
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
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