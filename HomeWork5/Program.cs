// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве

// int[] ArrayGenerator(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);

//     return array;
// }

// void ShowArray(int[] array) // функция используется в задаче 34 и задаче 36
// {
//     Console.Write("Массив: ");

//     for(int i=0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.Write("\n");
// }

// int CountDigits(int[] array)
// {
//     int count = 0;

//     for(int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0)
//             count++;

//     return count;
// }

// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = ArrayGenerator(n);
// ShowArray(myArray);
// Console.WriteLine("Количество четных элементов массива: " + CountDigits(myArray));




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных 
// позициях.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// int NumbersSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 1; i < array.Length; i += 2)
//         sum += array[i];

//     return sum;
// }

// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// NumbersSum(myArray);
// Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях: " + NumbersSum(myArray));



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// double[] ArrayRealNumbers(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//         array[i] = Math.Round((new Random().NextDouble()), 3) + new Random().Next(minValue, maxValue);

//     return array;
// }

// void ShowRealArray(double[] array)
// {
//     Console.Write("Массив: ");

//     for(int i=0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.Write("\n");
// }

// double DifferenceOfNumbers(double[] array)
// {
//     double minNum = array[0];
//     double maxNum = array[0];
//     double diff = 0;

//     for(int i = 0; i < array.Length; i++)
//         if(minNum > array[i])
//             minNum = array[i];
//         else if(maxNum < array[i])
//             maxNum = array[i];
    
//     if(minNum < 0 && maxNum > 0)
//         diff = maxNum - (minNum * (-1));
//     else
//         diff = maxNum - minNum;
//     return diff;
// }

// Console.Write("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] myArray = ArrayRealNumbers(n, min, max);
// ShowRealArray(myArray);
// DifferenceOfNumbers(myArray);
// Console.Write("Разницу между максимальным и минимальным элементами массива составляет:" + DifferenceOfNumbers(myArray));


