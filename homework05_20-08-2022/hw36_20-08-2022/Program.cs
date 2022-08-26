// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива:  ");

int size = Convert.ToInt32(Console.ReadLine()); // вводим число, означающее размер массива

int[] numbers = new int[size]; // создаём новый массив

FillArrayRandomNumbers(numbers); // заполняем массив с помощью функции заполнения

Console.WriteLine("Массив: "); // выводим в терминале сам массив...

PrintArray(numbers); // ... с помощью функции вывода в терминал

int oddPosSum = 0; // начальное значение суммы чисел на нечётных позициях

// подсчитываем числа сумму чисел на нечётных позициях
for (int i = 0; i < numbers.Length; i += 2)
    oddPosSum = oddPosSum + numbers[i];

Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях равна {oddPosSum}");

// функция заполнения массива
void FillArrayRandomNumbers(int[] numbers)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(1, 10);
    }
}

// функция вывода массива в терминал
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int k = 0; k < numbers.Length; k++)
    {
        Console.Write(numbers[k] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}