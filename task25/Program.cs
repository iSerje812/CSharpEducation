﻿/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/* Решение через метод:

double EponentiationOpetator(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);

    return result;
}

Console.WriteLine("Введитте число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(EponentiationOpetator(A, B));

double exponentiation = EponentiationOpetator(A, B);

Console.WriteLine($"Результат возведения числа {A} в степень {B} равен: {exponentiation}");
Console.WriteLine($"{B} степень числа {A} = {exponentiation}");
*/

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int exponentiation = A;
for (int i = 1; i < B; i++)
{
    exponentiation *= A;
}
Console.WriteLine(exponentiation);