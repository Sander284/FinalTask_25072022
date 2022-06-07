/* // Задача №2
//Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее. 

Console.Write("Введите число 1: ");
int One = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int Two = int.Parse(Console.ReadLine());

if (One > Two)
{
    Console.WriteLine("Наибольшее число: " + One);  
    Console.WriteLine("Наименьшее число: " + Two); 
}
else
{
    Console.WriteLine("Наибольшее число: " + Two); 
    Console.WriteLine("Наименьшее число: " + One); 
} */

//*******************************************************************************************

/* //Задача №4
//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел. 

Console.Write("Введите число 1: ");
int One = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int Two = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int Three = int.Parse(Console.ReadLine());

if ((One > Two) & (One > Three)) 
{
    Console.WriteLine("Наибольшее число: " + One);  
}
else if ((Two > One) & (Two > Three)) 
{
    Console.WriteLine("Наибольшее число: " + Two);
} 
else
{
    Console.WriteLine("Наибольшее число: " + Three);
}    */

//*************************************************************************************************

/* // Задача№6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

Console.Write("Введите число: ");
int One = int.Parse(Console.ReadLine());

if (One%2<1)
{
    Console.WriteLine("Число является четным");  
}
else
{
    Console.WriteLine("Число не является четным");  
} */

//************************************************************************************************

// Задача№8
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа 
//от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int index = 2;

while (N>index)
{
    Console.WriteLine(index);
    index = index + 2;
}
