// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

Start();

void Start()
{
  int rows = SetNumber("rows");
  int columns = SetNumber("columns");
  int min = SetNumber("min value  ");
  int max = SetNumber("max value  ");

  int[,] matrix = GetMatrix(rows, columns, min, max);
  PrintMatrix(matrix);
  MethodArrange(matrix);
  System.Console.WriteLine("Arranged array :");
  PrintMatrix(matrix);
}

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

void MethodArrange(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}