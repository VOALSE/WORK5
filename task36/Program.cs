// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] CreateArrayRnd(int size, int min, int max) //Массив рандомных чисел от min до max размером size
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int GetSumOddPos(int[] array) //Сумма элементов, стоящих на нечетных позициях.
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) result += array[i];
    }
    return result;
}

void PrintArray(int[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRnd(4, -10, 10);
PrintArray(array);
int sumOddPos = GetSumOddPos(array);

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sumOddPos}");
