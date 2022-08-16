// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: "); // Вывод текста

int numberN = Convert.ToInt32(Console.ReadLine()); // Строка ввода числа

// Функция вывода суммы цифр в числе
int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length; // преобразуем число в строку. Выводим количество символов в строке и присваиваем это значение переменной counter
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);

Console.WriteLine($"Сумма цифр в числе: {sumNumber}");