// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.

// void DecreasingNumbers(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) DecreasingNumbers(n - 1);
// }

// Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// DecreasingNumbers(num1);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// // от M до N.

// int SumNumbers(int m, int n)
// {
//     if(n < m) 
//         return SumNumbers(m, n + 1) + n;
//     else if(n > m)
//         return SumNumbers(m, n - 1) + n;
//     else
//         return m;
// }

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumNumbers(num1, num2));
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.

// int AckerrmanFunction(int m, int n)
// {
//     if(m > 0 && n == 0) 
//         return AckerrmanFunction(m - 1, 1);
//     else if(m > 0 && n > 0)
//         return AckerrmanFunction(m - 1, AckerrmanFunction(m, n - 1));
//     else
//         return n + 1;
// }

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(AckerrmanFunction(num1, num2));
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
