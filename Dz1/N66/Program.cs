// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Start();

void Start()
{
  int m = SetNumber("M ");
  int n = SetNumber("N ");
  
  SumFrom(m,n);
}
int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int GetSum(int m, int n)
{
  
  if (m == n)
    return 0;
  else
  {
    int res = m;
    m++;
    res = m + GetSum(m, n);
    return res;
  }
}
void SumFrom(int m, int n)
{
    Console.Write(GetSum(m - 1, n));
}