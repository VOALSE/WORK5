// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRnd(int size, int min, int max) //Массив рандомных вещественных чисел от min до max размером size
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
        arr[i] = Math.Round(arr[i], 1); // вещественные числа округляются до 1 знака после запятой
    }
    return arr;
}

double GetDiffMinMax(double[] array) //Поиск разницы между максимальным и минимальным элементов массива
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    result = Math.Round(max - min,1);
    return result;
}

void PrintArray(double[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRnd(5, 0, 100);
PrintArray(array);
Console.WriteLine();
double diffMinMax = GetDiffMinMax(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {diffMinMax}");
