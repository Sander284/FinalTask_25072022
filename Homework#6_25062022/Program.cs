/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


/* double M = new Random().Next(1, 8);
double pos = 0;
double neg = 0;
double[] mass = new double[M];

for (double i = 0; i < mass.Length; i++)
{
    Console.WriteLine("Введите число: ");
    mass[i] = double.Parse(Console.ReadLine());
}
for (double i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        pos++;
    }
}
Console.WriteLine("Количество введенных чисел больше 0: " + pos); */


/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

double b1 = 2.0;
double b2 = 4.0;
double k1 = 5.0;
double k2 = 9.0;
double x1 = -5.0;
double y1 = 0.0;
double y2 = 1.0;
double x2 = 0.0;

while (x1 < 10.0)
{
    if (y1 != y2)
    {
        y1 = b1 * x1 + k1;
        y2 = b2 * x1 + k2;
        x1 = x1 + 0.5;
    }
    else 
    {
        Console.WriteLine($"Точка пересечения: X = {x1}; Y1 = {y1}; Y2 = {y2};");
    }
}








