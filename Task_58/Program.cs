/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using static System.Console;

int[,] GetArray(int m, int min, int max)
{
  int[,] result = new int[m, m];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < m; j++)
    {
      result[i, j] = new Random().Next(min, max + 1);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}

int[,] MultipliMattrix(int[,] inArray1, int[,] inArray2)
{
  int[,] result = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
  for (int i = 0; i < inArray1.GetLength(0); i++)
  {
    for (int j = 0; j < inArray1.GetLength(0); j++)
    {
      for (int k = 0; k < inArray1.GetLength(0); k++)
      {
        result[i, j] += inArray1[i, k] * inArray2[k, j];
      }
    }
  }
  return result;
}

Write("Введите размер матриц: ");
int rowsСolumns = int.Parse(ReadLine()!);
int[,] array1 = GetArray(rowsСolumns, 1, 10);
int[,] array2 = GetArray(rowsСolumns, 1, 10);

// int[,] array1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
// int[,] array2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };

WriteLine();
PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();
PrintArray(MultipliMattrix(array1, array2));