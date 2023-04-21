// Задача 64:  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.



Console.Clear();

Start();

void Start()
{
  int m = SetNumber("M ");
  int n = SetNumber("N ");

  GetNatural(n,m);
}

int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void GetNatural(int n, int m)
{
  if (m > n )
for (int i = n; i <= m; i++)
    Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");
}
