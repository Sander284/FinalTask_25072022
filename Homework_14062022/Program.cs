// Zadanie #10 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Option#1
/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N > 99 & N < 1000)
{
    int A = N / 10;
    Console.WriteLine(A % 10); 
}
else Console.WriteLine("Ошибка, необходимо ввести 3-х значное число"); */


//Option#2
/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N > 99 & N < 1000)
{
    string str = N.ToString(); //преобразование в строку
    Console.WriteLine(str[1]); //вывод 2 знака 
}
else Console.WriteLine("Ошибка, необходимо ввести 3-х значное число"); */

//**********************************************************************************************************************

// Zadanie #15 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите номер дня недели: ");
int N = int.Parse(Console.ReadLine());

if (N > 0 & N < 8)
{
    if (N > 5 & N < 8)
    {
        Console.WriteLine("Да"); //вывод 2 знака
    } 
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Ошибка, необходимо ввести число от 1 до 7");
