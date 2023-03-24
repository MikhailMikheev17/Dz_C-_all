//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine(" Enter a number:");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
int count = 2; //первое четное число 

while (count <= number)
{
    Console.Write($"{count} ");
    count += 2;
}
if (number < count)
{
  Console.WriteLine("No even numbers.Please Enter another one.");
}