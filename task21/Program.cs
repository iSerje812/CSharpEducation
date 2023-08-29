/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты двух точек A и B в 3D пространстве:");
Console.WriteLine("Введите координаты точки A:");
int userXa = Convert.ToInt32(Console.ReadLine());
int userYa = Convert.ToInt32(Console.ReadLine());
int userZa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
int userXb = Convert.ToInt32(Console.ReadLine());
int userYb = Convert.ToInt32(Console.ReadLine());
int userZb = Convert.ToInt32(Console.ReadLine());

double rastoyanie = Math.Sqrt((Math.Pow(userXa-userXb, 2)+Math.Pow(userYa-userYb, 2)+Math.Pow(userZa-userZb, 2)));
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве равно {rastoyanie}");