/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/
/*
int[] GetRundomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);

    }
    return array;
}

int[] userArray = GetRundomArray();

void PrintArray(int[]arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.WriteLine($"({arrayToPrint[i]} )");
    }
}
PrintArray(userArray);
*/

/* 30/ Напишите программу которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке*/

int[] GetRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
    return array;
}
int[] userArray = GetRandomArray();

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