/* 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

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

void GetSum(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP = sumP + array[i];
        }
       else
        {
            sumN = sumN + array[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел равна {sumP}, сумма отрицательных чисел равна{sumN}");
}

Console.WriteLine("Введите длину и границы чисел массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

//int[] userArray = GetRandomArray(arrayLength, min, max);
//PrintArray(userArray)
//PrintArray(GetRandomArray(arrayLength, min, max));

int[] userArray = GetRandomArray(arrayLength, min, max);
PrintArray(userArray);
Console.WriteLine();
GetSum(userArray);
//Console.WriteLine($"Сумма положительных чисел равна: {GetSumP(userArray)} ");
//($"Сумма положительных чисел равна:{sumP}");
//Console.WriteLine//($"Сумма положительных чисел равна:{sumN}");