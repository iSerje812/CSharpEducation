/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
/*
int ProductOfNumber(int number)
{
    int product = 1;
    while (number != 0)
    {
        product *= number;
        number--;
    }
    return product;
}


System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ProductOfNumber(userNumber));
*/

int MultofNumbers(int number)
{
 int mult = 1;
 for (int i = 1; i <= number; i++)
 {
    mult *= i;
 }
 return mult;
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MultofNumbers(userNumber));