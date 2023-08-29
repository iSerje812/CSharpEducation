/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int backwaynumber = 0;
if (number > 9999 && number < 100000)
{
    for (int i = number; i > 0; i = i / 10)
    {
        backwaynumber = i % 10 + backwaynumber * 10;
    }
    if (number == backwaynumber)
        Console.WriteLine("Введенное число является Полиндромом!");
    else
        Console.WriteLine("Введенное число НЕ является Полиндромом!");
}
else Console.WriteLine("Ошибка! Введенное число не является пятизначным!");
