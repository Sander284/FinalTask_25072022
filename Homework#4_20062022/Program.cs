/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


//Решение через функцию.

/* int Func(int C)
{
    Console.WriteLine("Введите число А: ");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = int.Parse(Console.ReadLine());
    int D = Convert.ToInt32(Math.Pow(A, B));
    return D;
}

int C = 0;
Console.WriteLine(Func(C)); */


// обычное решение
/* Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
double C = Math.Pow(A, B);
Console.WriteLine(C); */


/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


//Решение через while

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int B = 0;
int sum = 0;

while (N > 1)
{
    B = N % 10; 
    sum = sum + B; 
    N = N / 10;
}
Console.WriteLine(sum); */


/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


/* int Func(int A)
{
    Console.WriteLine("Введите число: ");
    int B = int.Parse(Console.ReadLine());
    return B;
}

int A = 0;
Console.WriteLine($"[{Func(A)},{Func(A)},{Func(A)},{Func(A)},{Func(A)},{Func(A)},{Func(A)},{Func(A)},]"); */

Console.WriteLine("Введите количество элементов массива: ");
int B = int.Parse(Console.ReadLine());
int[] mass = new int[B];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 100);
}
Console.Write("[");
for (int i = 0; i < mass.Length; i++)
{
    if (i < (mass.Length - 1))
    {
        Console.Write(mass[i]+", ");
    }
    else 
    {
        Console.Write(mass[i]);
    }
}
Console.Write("]");

