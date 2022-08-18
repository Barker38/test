// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N для вывода таблицы кубов ");
int N = int.Parse(Console.ReadLine());
int a = 0;

void Cube(int b)
{
    for (int i = 1; i <= b; ++i)
        Console.WriteLine($"{i} | {i * i * i}");
}

if (N < 1)
{
    Console.WriteLine("Введите число >= 1");
    return;
}

Cube(N);

