// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // генерируем двумерный массив из вещественных чисел
// double[,] CreateRandomDouble2Array(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);

//     return array;
// }

// // выводим двумерный массив из вещественных чисел
// void ShowDouble2Array(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(Math.Round(array[i, j], 1) + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandomDouble2Array(m, n, min, max);
// ShowDouble2Array(myArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// // генерируем двумерный массив из целых чисел (для задач 50 и 52)
// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue) 
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// // выводим двумерный массив из целых чисел (для задач 50 и 52)
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

// // проверяем наличие элемента в массиве
// bool CheckingPosition(int rows, int columns, int[,] array)
// {
//     bool flag = false;

//     if(rows < array.GetLength(0) && columns < array.GetLength(1))
//         flag = true;
//     else
//         flag = false;

//     return flag;
// }

// // выводим результат
// void ShowPosition(int rows, int columns, int[,] array, bool flag)
// {
//     if(flag == true)
//         Console.WriteLine($"Element with values {rows} и {columns} is {array[rows, columns]}");
//     else
//         Console.WriteLine($"Element with values {rows} и {columns} is not");
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

// Console.Write("Input a number of search rows: ");
// int rowsSearch = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of search columns: ");
// int columnsSearch = Convert.ToInt32(Console.ReadLine());

// bool res = CheckingPosition(rowsSearch, columnsSearch, myArray);
// ShowPosition(rowsSearch, columnsSearch, myArray, res);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // дополнительно используются функции CreateRandom2Array и Show2Array из задачи 50
// // находим среднее арифметическое элементов в каждом столбце
// double[] SummColumnsArray2(int[,] array)
// {
//     double[] arraySumm = new double[array.GetLength(1)];

//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             arraySumm[j] += array[i, j];
//         }
//         arraySumm[j] /= array.GetLength(0);
//     }
//     return arraySumm;
// }

// // выводим одномерный массив с результатом
// void ShowArray(double[] array)
// {
//     Console.WriteLine("The arithmetic mean of the elements columns is: ");

//     for(int i=0; i < array.Length; i++)
//         Console.Write(Math.Round(array[i], 1) + " ");

//     Console.Write("\n");
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
// double[] res = SummColumnsArray2(myArray);
// ShowArray(res);


