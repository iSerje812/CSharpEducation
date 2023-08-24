// Напишите прогу которая по заданному номеру четверти показавыет диапазон возможных координат этой точки//
Console.WriteLine("Введите номер четверти");
int numberChetverti = Convert.ToInt32(Console.ReadLine());

if (numberChetverti == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (numberChetverti == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (numberChetverti == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (numberChetverti == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else Console.WriteLine("Нет такой четверти");