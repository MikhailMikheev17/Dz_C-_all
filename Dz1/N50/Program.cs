// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();


int rows = SetNumber("rows");
int columns = SetNumber("columns");
int min = SetNumber("min value  ");
int max = SetNumber("max value  ");

int[,] matrix = GetMatrix(rows, columns, min, max);
PrintMatrix(matrix);
int el = SetNumber("element");


int count = 0;
int endFlag = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if (matrix[i, j] == el)
    {
      endFlag = 1;
      System.Console.WriteLine($"index of {el} = {i} , {j}");
      count++;
    }
    if (endFlag == 1) break;
  }
  if (endFlag == 1) break;
}

if (count == 0) System.Console.WriteLine("There is no such element!");

int SetNumber(string numberName)
{
  Console.Write($"Enter {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
  int[,] array = new int[rows, columns];

  var rand = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = rand.Next(minValue, maxValue + 1);
    }
  }

  return array;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
  }
}








