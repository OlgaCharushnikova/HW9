// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите значние N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 1) 
{
    Console.WriteLine("N < 1! Введиде другое значние N: ");
    n = Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int n)
{
    int x = 1;
    if (n == x) Console.Write("1 ");
    else
    {
        Console.Write($"{n}, ");
        NaturalNumbers(n - 1);
    }
}       
NaturalNumbers(n);