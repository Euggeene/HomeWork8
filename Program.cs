// Seminar7

// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// Console.Write(array[i,j]+ " ");
// }

// Console.WriteLine();
// }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите число: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int collumns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,collumns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = i + j;
// Console.Write(array[i,j] + " ");
// }
// Console.WriteLine();
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// Console.Write(array[i,j]+ " ");
// }

// Console.WriteLine();
// }
// Console.WriteLine("______");
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if((i%2==0)&&(j%2==0))
// {
// array[i,j]= array[i,j]*array[i,j];
// }

// Console.Write(array[i,j]+ " ");
// }

// Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i,j] = new Random().Next(0,10);
// Console.Write(array[i,j]+ " ");
// }

// Console.WriteLine();
// }
// Console.WriteLine("______");

// int sum=0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if(i==j)
// {
// sum= sum+ array[i,j];
// }
// }
// }

// Console.WriteLine("Сумма "+sum);

// Seminar8

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] result = new int [rows,columns];


// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// result[i,j] = new Random().Next(0,10);
// }
// }

// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// Console.Write(result[i,j]);
// }

// Console.WriteLine();
// }


// for (int j = 0; j < result.GetLength(1); j++)
// {
// int temp = result[0,j];
// result[0,j]=result[result.GetLength(0)-1,j];
// result[result.GetLength(0)-1,j]= temp;
// }
// Console.WriteLine("________");

// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// Console.Write(result[i,j]);
// }

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] result = new int [rows,columns];
// GetArray();
// PrintArray();
// ChangeRows();
// PrintArray();

// void GetArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// result[i,j] = new Random().Next(0,10);
// }
// }
// }

// void PrintArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// Console.Write(result[i,j]);
// }

// Console.WriteLine();
// }
// Console.WriteLine();
// }

// void ChangeRows()
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// int temp = result[0,j];
// result[0,j]=result[result.GetLength(0)-1,j];
// result[result.GetLength(0)-1,j]= temp;
// }


// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = rows;

// int [,] result = new int [rows,columns];
// int [,] result2 = new int [rows,columns];

// void GetArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// result[i,j] = new Random().Next(0,10);
// }
// }
// }

// void PrintArray(int [,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]);
// }

// Console.WriteLine();
// }
// Console.WriteLine();
// }

// void ChangeArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
//   {
//    result2[j,i]=result[i,j];
//   }
// }
// }

// GetArray();
// PrintArray(result);
// ChangeArray();
// PrintArray(result2);

// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит стрименьший элемент массива.
// Например, задан массив:оку и столбец, 
// на пересечении которых расположен на
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = rows;

// int [,] result = new int [rows,columns];

// int minEl=int.MaxValue;
// int minRows=0;
// int minColumns=0;


// void GetArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// result[i,j] = new Random().Next(0,10);

// if (result[i,j]<minEl)
// {
// minEl=result[i,j];
// minRows=i;
// minColumns=j;
// }
// }
// }
// }

// void PrintArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// Console.Write(result[i,j]);
// }

// Console.WriteLine();
// }
// Console.WriteLine();
// }

// void ChangeArray()
// {
// for (int i = 0; i < result.GetLength(0); i++)
// {
//     if (i!=minRows)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             if (j!=minColumns)
//             {
//                 Console.Write(result[i,j]);
//             }
//         }
//         Console.WriteLine();
//     }
// }
// }
// GetArray();
// PrintArray();
// ChangeArray();
// Console.WriteLine(minEl);




// *HomeWork8*

// void ChangeRows()
// {
// for (int j = 0; j < result.GetLength(1); j++)
// {
// int temp = result[0,j];
// result[0,j]=result[result.GetLength(0)-1,j];
// result[result.GetLength(0)-1,j]= temp;
// }


// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.


Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = new int[rows, columns];

void GetArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i, j] + " ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortResult()
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = j + 1; k < result.GetLength(1); k++)
            {
                for (int i = 0; i < result.GetLength(0); i++)
                {
                if (result[0, j] < result[0, k])
                {
                    int temp = result[0, j];
                    result[0, j] = temp;
                    result[0, j] = result[0, k];
                    result[0, k] = temp;
                }
                }
            }
        }
    }

    GetArray();
    PrintArray();
    SortResult();
    PrintArray();


// Console.WriteLine("________");



// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = new int[rows, columns];

// void GetArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray()
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

// GetArray();
// PrintArray();
// Console.WriteLine("Cтрока с наименьшей суммой элементов" +  );