// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

int N = Convert.ToInt32(Console.ReadLine());

if (N == 1)
{
    Console.WriteLine("Monday");
}
else if (N == 2)
{
    Console.WriteLine("Tuesday");
}
else if (N == 3)
{
    Console.WriteLine("Wednesday");
}
else if (N == 4)
{
    Console.WriteLine("Thursday");
}
else if (N == 5)
{
    Console.WriteLine("Friday");
}
else if (N == 6)
{
    Console.WriteLine("Saturday");
}
else if (N == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Enter an integer from 1 to 7");
}