// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int number = 0;
while (true)
{
    Console.WriteLine("Введите пятизначное число ");
    if (int.TryParse(Console.ReadLine(), out number)) break;
    else
    {
        Console.WriteLine("Введите корректное число ");
    }
}

bool GetPalindrom(int num)
{
    int oldValue = num;
    int newValue = 0;
    while (num > 0 || num < 0)
    {
        int ostatok = num % 10;
        newValue = newValue * 10 + ostatok;
        num = num / 10;
    }
    return Math.Abs(newValue) == Math.Abs(oldValue);
}

if (GetPalindrom(number)) Console.WriteLine($"{number} -> Да");
else Console.WriteLine($"{number} -> Нет");