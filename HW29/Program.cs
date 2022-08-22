// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = new int[8];

void FillArray(int elem, int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < elem - 1; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]}");
        Console.Write($",");

    }
    Console.Write($"]");
}
FillArray(9, arr);




