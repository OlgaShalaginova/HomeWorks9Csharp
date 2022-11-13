//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akerman(int a, int b)
{
  if (a == 0) return b + 1;
  else if ((a != 0) && (b == 0)) return Akerman(a - 1, 1);
  else return Akerman(a - 1, Akerman(a, b - 1));
}

Console.WriteLine(Akerman(m, n));
