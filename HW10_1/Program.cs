// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// Че то не пушится..Уже была такая проблема.

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

void Chislo2(int num)
{
    int firstDigit = num % 100;
    int thirdDigit = firstDigit / 10;
    Console.WriteLine($"{a} -> {thirdDigit}");
}
Chislo2(a);

