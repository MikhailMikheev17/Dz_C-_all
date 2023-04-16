// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

  
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double Sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      Sum += matrix[i, j];
    }
    Console.Write($"{Sum / matrix.GetLength(0)} ");
  }

  //GetSrAr(matrix);
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



