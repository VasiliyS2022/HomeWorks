// Домашнее задание №3.


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10) Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");
}

Console.WriteLine("Введтие целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
*/



// Задача 19
// Напишите программу, которая принимает на вход число любой длины и проверяет, является ли оно палиндромом.
/*
void Palindrome(int num)
{
    int temp = num;
    int reverseNum = 0;
    while (temp > 0)
    {
        int digit = temp % 10;
        reverseNum = reverseNum * 10 + digit;
        temp = temp / 10;
    }
    if (num == reverseNum) Console.WriteLine($"Число {num} является палиндромом");
    else Console.WriteLine($"Число {num} не является палиндромом");
}

Console.WriteLine("Введтие целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
*/



//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    double vector1 = X2 - X1;
    double vector2 = Y2 - Y1;
    double vector3 = Z2 - Z1;
    double result = Math.Sqrt(Math.Pow(vector1, 2) + Math.Pow(vector2, 2) + Math.Pow(vector3, 2));
    return result;
}

Console.WriteLine("Input point X1: ");
double pointX1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point Y1: ");
double pointY1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point Z1: ");
double pointZ1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point X2: ");
double pointX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point Y2: ");
double pointY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input point Z2: ");
double pointZ2 = Convert.ToDouble(Console.ReadLine());

double lenghtPoints = Distance(pointX1, pointY1, pointZ1, pointX2, pointY2, pointZ2);
Console.WriteLine($"Distance between points {pointX1}, {pointY1}, {pointZ1} and points {pointX2}, {pointY2}, {pointZ2} is {Math.Round(lenghtPoints, 2)}");
*/



// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableSqrt(int N)
{   
    for(int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableSqrt(num);
*/
