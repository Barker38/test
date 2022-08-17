// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
    if (number > 99 || number < -99)
    {
        while (number > 1000 || number < -1000)
        {
            number = number / 10;
        }
        return number % 10;
    }
    else return -1;
}

int result = ThirdDigit(num);
string res = result == -1 ? "Третьей цифры нет" : result.ToString();
Console.WriteLine($"Третья цифра числа {num} -> {res}");