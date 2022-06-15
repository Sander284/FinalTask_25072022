/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

/* Console.WriteLine("Введите пятизначное число: ");
int A = int.Parse(Console.ReadLine());

string str = A.ToString(); //преобразование в строку */
/* Console.WriteLine(str[0]);
Console.WriteLine(str[1]);
Console.WriteLine(str[2]);
Console.WriteLine(str[3]);
Console.WriteLine(str[4]); 

//*****************************************************************************************************************************
/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.WriteLine("Введите координаты X числа А: ");
int XA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y числа А: ");
int YA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z числа А: ");
int ZA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X числа B: ");
int XB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y числа B: ");
int YB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z числа B: ");
int ZB = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты числа A[{XA},{YA},{ZA}]");
Console.WriteLine($"Координаты числа B[{XB},{YB},{ZB}]");

double Result = Math.Sqrt(Math.Pow(XA-XB,2) + Math.Pow(YA-YB,2) + Math.Pow(ZA-ZB,2));
Console.WriteLine("Расстояние между точками в пространстве: " + Math.Round(Result,2)); */

//*****************************************************************************************************************************
/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int index = 1; 

while (index <= N)
{
    Console.Write(Math.Pow(index,3) + ",");
    index++;
}