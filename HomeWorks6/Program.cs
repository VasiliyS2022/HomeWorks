
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void CountPositiveNumbers(int quantity)
// {
//     int count = 0;

//     if(quantity > 0)
//     {
//         Console.WriteLine("Введите первое число: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if(num > 0)
//             count++;

//         for(int i = 0; i < quantity - 1; i++)
//         {
//             Console.WriteLine("Введите следующее число: ");
//             num = Convert.ToInt32(Console.ReadLine());
//             if(num > 0)
//              count++;
//         }
//         Console.WriteLine(count);
//     }
//     else
//         Console.WriteLine(0);
// }

// Console.WriteLine("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// CountPositiveNumbers(M);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// int CheckingIntersection(double b1, double k1, double b2, double k2)
// {
//     int flag = 1;

//     if(k1 != k2) // пересекаются
//         flag = 1;

//     else if(k1 == k2 && b1 != b2) // параллельны
//         flag = 2;

//     else if(k1 == k2 && b1 == b2) // совпадают
//         flag = 3;
//     return flag;
// }

// void ShowResult(int flag, double b1, double k1, double b2, double k2)
// {
//     if(flag == 1)
//     {
//         Console.Write("Прямые пересекаются. Координаты пересечения: ");
//         double x = Math.Round((b2 - b1)/(k1 - k2), 2);
//         double y = Math.Round(k1 * ((b2 - b1)/(k1 - k2)) + b1, 2);
//         Console.Write($"X({x}), Y({y}).");
//     }
//     else if(flag == 2)
//         Console.Write("Прямые параллельны.");
//     else if(flag == 3)
//         Console.Write("Прямые совпадают.");
// }

// Console.WriteLine("Введите значение b1: ");
// double point_b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k1: ");
// double point_k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// double point_b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// double point_k2 = Convert.ToDouble(Console.ReadLine());

// int res = CheckingIntersection(point_b1, point_k1, point_b2, point_k2);
// ShowResult(res, point_b1, point_k1, point_b2, point_k2);