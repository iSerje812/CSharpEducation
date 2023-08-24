/*
Напишите программу которая на ввод принимает координаты 2х точек и находит расстояние между ними в 2D пронстранстве
*/
Console.WriteLine("Введите координаты двух точек A и B");
Console.WriteLine("Введите координаты точки A:");
int userXa = Convert.ToInt32(Console.ReadLine());
int userYa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
int userXb = Convert.ToInt32(Console.ReadLine());
int userYb = Convert.ToInt32(Console.ReadLine());

double rastoyanie = Math.Sqrt((Math.Pow(userXa-userXb, 2)+Math.Pow(userYa-userYb, 2)));
Console.WriteLine($"Расстояние между точками A и B равно {rastoyanie}");