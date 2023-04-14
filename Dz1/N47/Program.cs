// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

Start();

void Start()
{
  int rows = SetNumber("rows");
  int columns = SetNumber("columns");
  int min = SetNumber("min value  ");
  int max = SetNumber("max value  ");

  double[,] matrix = GetMatrix(rows, columns,min, max);
  PrintMatrix(matrix);
}

int SetNumber(string numberName)
{
  Console.Write($"Enter number {numberName}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

double[,] GetMatrix(int rows, int columns,int minValue,int maxValue)
{
  double[,] array = new double[rows, columns];

  var rand = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()), 2);
    }
  }

  return array;
}

void PrintMatrix(double[,] matrix)
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