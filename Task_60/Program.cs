/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

using static System.Console;

void PrintArray(int[,,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int k = 0; k < inArray.GetLength(2); k++)
    {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
        Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
      }
      WriteLine();
    }
  }
}

int[,,] array = new int[2, 2, 2] {{{66, 27}, {25, 90}}, {{34, 26}, {41, 55}}};
WriteLine();
PrintArray(array);