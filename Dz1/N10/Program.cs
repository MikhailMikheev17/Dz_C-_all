//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.WriteLine(" Enter a number :");
int num = Convert.ToInt32(Console.ReadLine());

int numSer = (num/10)%10;
Console.WriteLine(numSer);