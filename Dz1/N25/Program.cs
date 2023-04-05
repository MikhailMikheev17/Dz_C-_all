// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Clear();

int SetNumber(string text ="")
{
  System.Console.WriteLine($"Enter a number{text} :");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int Pow(int powBase, int exp)
{
  int pow = 1;
  for (int i= 0; i < exp; i ++)
  {
    pow *= powBase;
  }
  return pow;
}

bool ValidateExp(int exp)
{
  if (exp < 0)
  {
    System.Console.WriteLine("exp < 0");
    return false;
  }
  return true;
}

int powBase = SetNumber();
int exp = SetNumber();

if (ValidateExp(exp))
{
  System.Console.WriteLine($"Base = {powBase} , exp = {exp}. Pow = {Pow(powBase,exp)}");
}