// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод координат
int x1 = enteringCoordinates("x", "A");
int y1 = enteringCoordinates("y", "A");
int z1 = enteringCoordinates("z", "A");
int x2 = enteringCoordinates("x", "B");
int y2 = enteringCoordinates("y", "B");
int z2 = enteringCoordinates("z", "B");

int enteringCoordinates(string coordinate, string pointName) // функция ввода координат
{
    Console.Write($"Введите координату {coordinate} точки {pointName}: "); // вывод текста
    return Convert.ToInt16(Console.ReadLine()); // ввод координат
}

// функция расчёта расстояния. Функция принимает в качестве аргументов координаты точек
double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double segLen = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2); // округляем полученное значение до двух знаков после запятой

Console.WriteLine($"Длина отрезка  {segLen}");
