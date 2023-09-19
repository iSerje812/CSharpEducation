/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int figure = 0;
for (int i = number; i > 0; i= i / 10 )
{
    figure = i % 10 + figure;
}

Console.WriteLine(figure);
