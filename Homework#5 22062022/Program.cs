/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

/* int count = 0;
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] mass = new int[N];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100,1000);
}
Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

for (int i = 0; (i < mass.Length); i++)
{
    if (mass[i] % 2 < 1)
    {
        count++;
    }
}
Console.WriteLine("Количество четных: " + count); */


/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* int summ = 0;
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] mass = new int[N];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100,100);
}
Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

for (int i = 1; i < mass.Length; i=i+2)
{
    summ = summ + mass[i];
}
Console.WriteLine("Количество четных: " + summ);  */

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76 */

int max = 0;
int min = 100;
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] mass = new int[N];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100,100);
}
Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        max = mass[i];
    }
    else
    {
        max = max;
    }
}
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > min)
    {
        min = min;
    }
    else
    {
        min = mass[i];
    }
}
Console.WriteLine("Разница между максимальным и минимальным значениями: " + (max - min));
