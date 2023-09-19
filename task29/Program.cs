/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите длину и границы чисел массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int arrayLength)

{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int[] userArray = GetRandomArray(arrayLength);

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write($"{arrayToPrint[i]} ");
    }
    Console.Write("]");
}

PrintArray(userArray);
