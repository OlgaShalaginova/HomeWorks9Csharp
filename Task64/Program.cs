//Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 2;
if (n%2 == 1) 
{
    n = n-1;
}

string NumbersRecMinus(int a, int b)
{
    if (a == b) return $"{a} ";
    else return  NumbersRecMinus(a + 2, b) + $"{a} ";
}

Console.WriteLine(NumbersRecMinus(a, n));
