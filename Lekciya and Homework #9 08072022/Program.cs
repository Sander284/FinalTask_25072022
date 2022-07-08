//ПРОСТОЙ ПРИМЕР РЕКУРСИИ #1
/* 
void rec(int n) //создание функции рекурсии, будет выполняться n раз
{
    if (n == 0)
    {
        Console.WriteLine("Это конец рекурсии!");
        return;
    }
    Console.WriteLine("Это рекурсия");
    rec(n-1); //что бы рекурсия остановилась
}
rec(10); //вызов рекурсии с просьбой ее сделать 10 раз.
 */

//ПРОСТОЙ ПРИМЕР РЕКУРСИИ #2
/* 
int rec(int n, string s, bool b) //создание функции рекурсии, будет выполняться n раз
{
    if (n == 0)
    {
        Console.WriteLine("Это конец рекурсии!");
        return 0;
    }
    int result = 0;
    result = n + n + 8;
    Console.WriteLine("Это рекурсия" + s + b);
   
    return result + rec(n-1, s + " " + n, b);
}
Console.WriteLine("Результат рекурсии" + rec(10, " , передали строку, ", false)); //вызов рекурсии с просьбой ее сделать 10 раз.
 */

//ПРОСТОЙ ПРИМЕР РЕКУРСИИ #2 - ВОЗВЕДЕНИЕ ЧИСЛА В СТЕПЕНЬ N

/*  int rec(int n)
 {
    if (n == 0)
    {
        Console.WriteLine("Это конец рекурсии");
        return 1;
    }
    Console.WriteLine("Это рекурсия");
    return 2 * rec(n-1);
 }
 Console.WriteLine("Результат рекурсии: " + rec(10)); */



/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */


/* 
void PrintNumbers(int n)
{
    if (n == 0)
    {
        return;
    }
        PrintNumbers(n-1);
        Console.Write(n + " ");  
}
PrintNumbers(6); */


/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

//ВАРИАНТ №1

/* int m = 3;
int n = 9;
void PrintNumbers(int n)
{
    if (n == m-1)
    {
        return;
    }
        PrintNumbers(n-1);
        Console.Write(n + " ");  
}
PrintNumbers(n); */

//ВАРИАНТ №2

/* void PrintNumbers(int n, int m)
{
    if (n == m)
    {
        return;
    }

    Console.Write(n + " ");
    PrintNumbers(n + 1, m);
}
PrintNumbers(4,9); */

/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

/* Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int rec(int n)
{
    if (n == 0)
    {
        Console.WriteLine("Это конец рекурсии");
        return 0;
    }
    return n % 10 + rec(n / 10); //поиск остатка
}
Console.WriteLine("Результат рекурсии: " + rec(n)); */

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

//РЕШЕНИЕ ОСНОВНОЕ

/* Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int rec(int A, int B)
{
    if (B == 0)
    {
        Console.WriteLine("Это конец рекурсии");
        return 1;
    }
    return A * rec(A, B-1); 
    
}
Console.WriteLine("Результат рекурсии: " + rec(A, B)); */

//РЕШЕНИЕ АЛЬТЕРНАТИВНОЕ ДОПУСКАЮЩЕЕ ОТРИЦАТЕЛЬНЫЕ СТЕПЕНИ

/* Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
double rec(int A, int B)
{
    if (B == 0)
    {
        Console.WriteLine("Это конец рекурсии");
        return 1;
    }
    if (B < 0)
    {
        return (1.0 / A) * rec(A, B+1); //1.0 превращение числа в дабл
    }
    
    return A * rec(A, B-1); 
    
}
Console.WriteLine("Результат рекурсии: " + rec(A, B)); */


//ДОМАШНЕЕ ЗАДАНИЕ 08072022

/* Задача 64: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

/* int m = 2;
int n = 9;
void PrintNumbers(int n)
{
    if (n == m - 1)
    {
        return;
    }
    if (m <= n)
    {
    PrintNumbers(n - 1);
    Console.Write(n + " ");
    }
    else 
    {
        PrintNumbers(n + 1);
        Console.Write(n + " ");
        
    }
}
PrintNumbers(n); */

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* int M = 1;
int N = 15;
int rec(int N)
{
    if (N == M-1)
    {
    return 0;
    }
    return N + rec(N - 1); 
}
Console.WriteLine("Результат рекурсии: " + rec(N)); */

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int m = 0;
int n = 2;
int a(int m, int n)
{
    if (n == 0)
    {
        return 0;
    }
    if (m == 0)
    {
        return n + 1; 
    }
    if ((m > 0) & (n = 0))
    {
        return a(m-1, 1); 
    }
    if ((m > 0) & (n > 0))
    {
        return a((m - 1), a(m, n - 1)); 
    }
}
Console.WriteLine("Результат рекурсии: " + a(m, n));




