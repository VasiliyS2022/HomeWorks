// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int PowerOfNumber(int a, int b)
{
    int power = 1;

    for(int i = 1; i <= b; i++)
        power *= a;

        return power;
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num1} в степени {num2} равно {PowerOfNumber(num1, num2)}");
*/



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummDigits(int number)
{
    int summ = 0;
    int temp = number;

    while(number != 0)
    {
        temp = number % 10;
        number /= 10;
        summ += temp;
    }

    return summ;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num} равна {SummDigits(num)}");
*/



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());  //Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Array is: ");

    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.Write(" :) \n");
}

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива: ");


int[] myArray = CreateRandomArray(m);
ShowArray(myArray);
*/
