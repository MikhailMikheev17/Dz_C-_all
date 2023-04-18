// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Start();

void Start()
{
  int rows = SetNumber("rows");
  int columns = SetNumber("columns");
  int min = SetNumber("min value  ");
  int max = SetNumber("max value  "); 

  int[,] matrixA = GetMatrix(rows, columns, min, max);
  PrintMatrix(matrixA);
  System.Console.WriteLine();

  int[,] matrixB = GetMatrix(rows, columns, min, max);
  PrintMatrix(matrixB);
  System.Console.WriteLine();

  int[,] resMatrix = GetNewMatrix(matrixA,matrixB);
  PrintMatrix(resMatrix);
  
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

int[,] GetNewMatrix(int[,] arrayA, int[,] arrayB)
{
  int[,] arr = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arrayA.GetLength(0); k++)
      {
        arr[i, j] += arrayA[i, k] * arrayB[k, j];        
      } 
    }
    
  }
  return arr;
}
