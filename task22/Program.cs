/*
Напишите прогу которая на ввод принимает число N и выдает таблицу квадратов чисел от 1 до N
*/

using System.Runtime.Serialization.Formatters;

Console.WriteLine("Введите число N:");

int N = Convert.ToInt32(Console.ReadLine());
double result = 0;
if (N < 0)
{
    N = N * (-1);
}
for (int i = 1; i <= N; i++)
{
    result = Math.Pow(i, 2);
    Console.WriteLine(result);
}