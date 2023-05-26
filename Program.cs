// *HomeWork8*

// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];

//     Getresult();
//     Printresult();
//     SortResult();
//     Printresult();

// void Getresult()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void Printresult()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SortResult()
// {
//   for (int i = 0; i < result.GetLength(0); i++)
//   {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//       for (int k = 0; k < result.GetLength(1) - 1; k++)
//       {
//         if (result[i, k] < result[i, k + 1])
//         {
//           int temp = result[i, k + 1];
//           result[i, k + 1] = result[i, k];
//           result[i, k] = temp;
//         }
//       }
//     }
//   }
// }



// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];

// Getresult();
// Printresult();

// int minSumLine = 0;
// int sumLine = SumLineElements(result, 0);
// for (int i = 1; i < result.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(result, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] result, int i)
// {
//   int sumLine = result[i,0];
//   for (int j = 1; j < result.GetLength(1); j++)
//   {
//     sumLine += result[i,j];
//   }
//   return sumLine;
// }

// void Getresult()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void Printresult()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Console.WriteLine($"\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
// Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// Getarray3D(array3D);
// Printarray3D(array3D);

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// void Getarray3D(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 array3D[i, j, k] = new Random().Next(10, 100);
//             }

//         }
//     }
// }

// void Printarray3D(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]} ({i} , {j} , {k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine($"Заполняем спирально массив 4 на 4.");

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }