// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Enter coordinates  point A : ");
int numAx = int.Parse(Console.ReadLine());
int numAy = int.Parse(Console.ReadLine());
int numAz = int.Parse(Console.ReadLine());

Console.WriteLine("Enter coordinates  point B : ");
int numBx = int.Parse(Console.ReadLine());
int numBy = int.Parse(Console.ReadLine());
int numBz = int.Parse(Console.ReadLine());

double l = Math.Pow(Math.Pow(numBx-numAx,2)+Math.Pow(numBy-numAy,2)+Math.Pow(numBz-numAz,2),0.5);

System.Console.WriteLine($"distance = {l}");


