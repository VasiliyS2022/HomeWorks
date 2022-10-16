// ДОМАШНЕЕ ЗАДПНИЕ №1.



// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine($"Число {num1} большее, а число {num2} меньшее");
else
    Console.WriteLine($"Число {num2} большее, а число {num1} меньшее");
*/



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2 & num1 > num3)
    Console.WriteLine($"Максимальное число - это {num1}");
if (num2 > num1 & num2 > num3)
    Console.WriteLine($"Максимальное число - это {num2}");
if (num3 > num1 & num3 > num2)
    Console.WriteLine($"Максимальное число - это {num3}");
*/



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine($"Число {num} является четным");
else
    Console.WriteLine($"Число {num} не является четным");
*/



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;
Console.Write($"Четные числа от 1 до {N}: ");
while (current <= N)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/


