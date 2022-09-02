// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента в строке: ");
int posy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце: ");
int posx = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void SearchElem(int[,] searchmatrix, int y, int x)
{
    int findelem = 0;
    if (x > searchmatrix.GetLength(0) || y > searchmatrix.GetLength(1))
        Console.Write("{0},{1} -> Такой элемента в массиве нет", y, x);
    else
    {
        findelem = searchmatrix[x - 1, y - 1];
        Console.WriteLine($"{findelem}");
    }

}

int[,] resul = CreateMatrix(4, 3, 1, 15);

PrintMatrix(resul);
SearchElem(resul, posy, posx);