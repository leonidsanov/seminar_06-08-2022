// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int cubeNumbers = Convert.ToInt32(Console.ReadLine());

// функция считает кубы чисел
void Cube(int[] cubeNumbers)
{
    int count = 0;
    int length = cubeNumbers.Length;
    while (count < length)
    {
        cubeNumbers[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

// функция печатает кубы чисел
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] array = new int[cubeNumbers + 1];
Cube(array);
PrintArray(array);