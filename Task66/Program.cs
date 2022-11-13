// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int NumbersSumRec(int a, int b)
{
    if (a == b) return b;
    else if (a < b) return b + NumbersSumRec(a, b - 1);
    else if (a > b) return b + NumbersSumRec(a, b + 1);
    else return b;
}

Console.WriteLine(NumbersSumRec(m, n));
