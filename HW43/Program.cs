// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: "); //Просим у пользователя данные  
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] Intersection(double b11, double k11, double b22, double k22)
{
    double[] interarr = new double[3];
    if (k11 == k22 && b11 == b22) interarr[2] = -2;
    else if (k11 == k22) interarr[2] = -1;
    else
    {
        interarr[0] = (b22 - b11) / (k11 - k22);
        interarr[1] = k11 * interarr[0] + b11;
    }
    return interarr;
}
void PrintArray(double[] array) //Вывод массива 
{
    Console.Write("(");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 2) Console.Write("{0}, ", array[i]);
        else Console.Write(array[i]);
    }
    Console.Write(")");
}

double[] inters = Intersection(b1, k1, b2, k2);
if (inters[2] != 0) Console.Write(inters[2] < -1 ? "Совпадают" : "Параллельны");
else
{
    Console.Write($"b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3} -> ", b1, k1, b2, k2);
    PrintArray(inters);
}
