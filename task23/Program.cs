﻿/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N:");

int N = Convert.ToInt32(Console.ReadLine());
double result = 0;
if (N < 0)
{
    N = N * (-1);
}
for (int i = 1; i <= N; i++)
{
    result = Math.Pow(i, 3);
   System.Console.WriteLine($"Таблица кубов чисел от 1 до N[{result}]");
    //Console.WriteLine(result);
}
//System.Console.WriteLine($"Точка [{userX} : {userY}] находится в первой четверти");