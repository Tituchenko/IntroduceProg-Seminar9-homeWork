//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.Write ("Введите N:");
int n=int.Parse (Console.ReadLine()!);
Console.WriteLine($"N= {n} -> {GetNaturalNums(n)}");

string GetNaturalNums (int n)
{
    if (n==1) return "1";
    return $"{n.ToString()}, {GetNaturalNums(n-1)}";
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write ("Введите M:");
int m=int.Parse (Console.ReadLine()!);
Console.Write ("Введите N:");
int n=int.Parse (Console.ReadLine()!);

Console.WriteLine($"M= {m}; N={n} -> {GetSum(m,n)}");

int GetSum (int m,int n)
{
    int step=1;
    if (m==n) return n;
    if (m>n) step=-1; //А вдруг
    return m+GetSum(m+step,n);
}