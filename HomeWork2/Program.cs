// ДОМАШНЕЕ ЗАДАНИЕ №2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TwoDigit(int number)
{
    int minusEd = number % 100;
    int result = minusEd / 10;

    return result;
}

Console.Write("Введите трехзначное целое число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int newNum = TwoDigit(numb);

Console.WriteLine($"Вторая цифра числа {numb} равна {newNum}");
*/



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
// Вычисление длины числа
int Quantity(int digit)
{
    int count = 0;
    while (digit != 0)
    {
        digit = digit / 10;
        count++;
    }
    return count;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int lenght = Quantity(num);

// проверка длины числа
bool Check(int digit)
{
    if (lenght > 2)
        return true;
    else
        return false;
}

bool a = Check(lenght);


if (a == true)
{
// Вычисление третьей цифры
int ThreeDigit(int numb, int digit)
{int temp = 1; 
while (digit != 3)
    {
        temp = temp * 10;
        digit--;
    }
    int res = numb / temp % 10;
    return res;
}
int result = ThreeDigit(num, lenght);
Console.Write($"Третья цифра числа {num} равна {Math.Abs(result)}");
}
else
{
   Console.Write($"В числе {num} третьей цифры нет"); 
}
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayWeek(int number)
{
    if (number == 6 || number == 7)
        return true;
    else
        return false;
}

Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int numb = Convert.ToInt32(Console.ReadLine());

bool result = DayWeek(numb);

Console.WriteLine(result);
*/