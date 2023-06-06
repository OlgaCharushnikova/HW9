// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введиет значние M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет значние N: ");
int n = Convert.ToInt32(Console.ReadLine());

int t = 0;
if (m > n) 
{
   t = m;
   m = n;
   n = t;
}

int SumNaturalNumbers(int m, int n)
{
    if( n == m) return m;
    else
    {
        return SumNaturalNumbers(m, n - 1) + n;
    }
}

Console.WriteLine(SumNaturalNumbers(m, n));