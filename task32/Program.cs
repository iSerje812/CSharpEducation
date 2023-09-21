﻿/*32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
 и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите длину и границы чисел массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);

int[] ChangedSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
Console.WriteLine();
PrintArray(ChangedSignArray(userArray));