// Задача 64:  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.



Console.Clear();

Start();

void Start()
{
  int m = SetNumber("M ");
  int n = SetNumber("N ");

  //NaturalToLow(n,m);
  NaturalMToN(n, m);
}

int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}

void NaturalMToN(int n, int m)
{
  NaturalToLow(n, m );
}