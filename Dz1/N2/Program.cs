//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Enter first number :");
string numFirst = Console.ReadLine();
int numF = Convert.ToInt32(numFirst);
Console.WriteLine("Enter second number :");
string numSecond = Console.ReadLine();
int numS = Convert.ToInt32(numSecond);

if (numF > numS )
{
  Console.WriteLine(" The First number is bigger than the second one");
}
else Console.WriteLine("The Second number is bigger than the first one");