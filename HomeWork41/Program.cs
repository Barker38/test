// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество чисел ");
int countdig = Convert.ToInt32(Console.ReadLine());
//int[] digarray = new int[];

int[] AddDigitArr(int size) //Заполнение массива цифрами
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите целое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array) //Вывод массива 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write("{0}, ", array[i]);
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int SearchDig(int[] sarr) //Метод поиска чисел в массиве больше 0
{
    int sdig = 0;
    for (int i = 0; i < sarr.Length; i++)
    {
        if (sarr[i] > 0) sdig = sdig + 1;
    }
    return sdig;
}

int[] result = AddDigitArr(countdig);
PrintArray(result);
countdig = SearchDig(result);
Console.Write(" -> {0}", countdig);


