// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}");
//         }
//         Console.WriteLine("");
//     }
// }
// void Streamline(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < array.GetLength(1) - 1; z++)
//             {
//                 if (array[i, z] < array[i, z + 1])
//                 {
//                     int temp = 0;
//                     temp = array[i, z];
//                     array[i, z] = array[i, z + 1];
//                     array[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }
// FillArray(array);
// Console.WriteLine("");
// PrintArray(array);
// Streamline(array);
// Console.WriteLine("");
// PrintArray(array);


// Задача 56: Задайте прямоугольный 
// двумерный массив. Напишите программу, 
// которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}");
//         }
//         Console.WriteLine("");
//     }
// }
// int minSumRows = 9;
// int indexRow = 0;
// int sum = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     if (sum < minSumRows)
//     {
//         minSumRows = sum;
//         indexRow = indexRow + 1;
//     }
// }
// FillArray(array);
// Console.WriteLine("");
// PrintArray(array);
// Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexRow) + ", с суммой элементов равной: " + (minSumRows));



// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] matrix1 = new int[2, 2];
// int[,] matrix2 = new int[2, 2];
// int[,] ResultMatrix = new int[2, 2];
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// FillArray(matrix1);
// FillArray(matrix2);
// void PrintArray(int[,] array1, int[,] array2)
// {
//     for (int row = 0; row < array1.GetLength(0); row++)
//     {
//         for (int col = 0; col < array1.GetLength(1); col++)
//             Console.Write(array1[row, col] + " ");
//         Console.Write(" | ");
//         for (int col = 0; col < array2.GetLength(1); col++)
//             Console.Write(array2[row, col] + " ");
//         Console.WriteLine();
//     }
// }
// PrintArray(matrix1, matrix2);
// void MultiplyMatrix(int[,] m1, int[,] m2, int[,] RM)
// {
//     for (int i = 0; i < RM.GetLength(0); i++)
//     {
//         for (int j = 0; j < RM.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < RM.GetLength(1); k++)
//             {
//                 result += m1[i, k] * m2[k, j];
//             }
//             RM[i, j] = result;
//         }
//     }
// }
// void PrintResult(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }
// MultiplyMatrix(matrix1, matrix2, ResultMatrix);
// Console.WriteLine("Произведение двух матриц: ");
// PrintResult(ResultMatrix);


// Задача 60: Сформируйте трёхмерный 
// массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");
// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);
// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }
// void WriteArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// void CreateArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }


// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] matrix = new int[n, n];
// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
// {
//     matrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= matrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > matrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($"0{array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(matrix);