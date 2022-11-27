// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// // строки двумерного массива.

// // создание двумерного массива (для задач 54, 56, 58)
// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// // вывод двумерного массива (для задач 54, 56, 58)
// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // сортировка строк двумерного массива по убыванию
// int[,] SortArray(int[,] array)
// {
//     for( int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if(array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2Array(m, n, min, max);
// Console.WriteLine("Source array: ");
// Show2Array(myArray);
// int[,] sortArray = SortArray(myArray);
// Console.WriteLine("Sorted array: ");
// Show2Array(sortArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// // суммой элементов.

// // дополнительно используются методы CreateRandom2Array и Show2Array (см. задачу 54)

// // вывод номера строки массива с наименьшей суммой элементов
// void ShowRow(int[,] array)
// {
//     int sumTemp = 0;
//     int row = 0;
//     int sumRow = 0;

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         sumTemp += array[0, i];
//     }
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++) 
//             sumRow += array[i, j];
//                 if (sumRow < sumTemp)
//                 {
//                     sumTemp = sumRow;
//                     row = i;
//                 }
//             sumRow = 0;
//         }
//     Console.Write($"{row + 1} строка");
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2Array(m, n, min, max);
// Show2Array(myArray);
// ShowRow(myArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// // дополнительно используются методы CreateRandom2Array и Show2Array (см. задачу 54)

// // произведение массивов
// int[,] MultiArray(int[,] myArray1, int[,] myArray2)
// {
//     int[,] resArray = new int[myArray1.GetLength(0), myArray2.GetLength(1)];
//     if (myArray1.GetLength(1) == myArray2.GetLength(0))
//     {
//         for (int i = 0; i < resArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < resArray.GetLength(1); j++)
//             {
//                 for (int a = 0; a < myArray1.GetLength(1); a++)
//                 {
//                     resArray[i, j] += myArray1[i, a] * myArray2[a, j];
//                 }
//             }
//         }
//     }
//     return resArray;
// }

// Console.Write("Input a size of side of array: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray1 = CreateRandom2Array(s, s, min, max);
// int[,] myArray2 = CreateRandom2Array(s, s, min, max);
// Show2Array(myArray1);
// Show2Array(myArray2);
// int[,] resArray = MultiArray(myArray1, myArray2);
// Show2Array(resArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// // будет построчно выводить массив, добавляя индексы каждого элемента.

// // создание трехмерного массива
// int[,,] CreateRandom3Array(int list, int rows, int columns)
// {
//     int[,,] array = new int[list, rows, columns];
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//                 while(Contains(array, array[i, j, k]))
//                 {
//                     array[i, j, k] = new Random().Next(10, 100);
//                 }
//             }
//         }
//     }
//     return array;
// }
// bool Contains(int[,,] array, int number)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == number)
//                     count++;
//             }
//         }
//     }
//     return count > 1;
// }

// // вывод трехмерного массива
// void Show3Array(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // число элементов массива должно быть (l * m * n <= 90)
// Console.Write("Input a number of list: ");
// int l = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = CreateRandom3Array(l, n, m);
// Show3Array(myArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// // создание спирального массива
// int[,] SpiralArray(int n)
// {
//     int[,] array = new int[n, n];
//     int startValue = 1;

//     for (int i = 1; i <= n / 2; i++)
//     {
//         for (int j = i - 1; j < n - i + 1; j++)
//         {
//             array[i - 1, j] = startValue++;
//         }
//         for (int j = i; j < n - i + 1; j++)
//         {
//             array[j, n - i] = startValue++;
//         }
//         for (int j = n - i - 1; j >= i - 1; j--)
//         {
//             array[n - i, j] = startValue++;
//         }
//         for (int j = n - i - 1; j >= i; j--)
//         {
//             array[j, i - 1] = startValue++;
//         }
//     }
//     if (n % 2 == 1) array[n / 2, n / 2] = n * n;

//     return array;
// }

// // вывод массива и добавление ведущих нулей
// void Show2ArraySpiral(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             if(array[i, j] < 10)
//                 Console.Write("0" + array[i, j] + " ");
//             else
//                 Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a size of side square: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = SpiralArray(s);
// Show2ArraySpiral(myArray);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////

