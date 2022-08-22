// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

int natur(int num1, int num2)
{
    int number = 1;
    for (int i = 1; i != num2 + 1; i++)
    {
        number = number * num1;
    }
    return number;
}

int result = natur(a, b);
Console.WriteLine($"{result}");





