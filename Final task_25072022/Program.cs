//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина 
//которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество элементов массива: ");
int B = int.Parse(Console.ReadLine()); 
string[] mass = new string[B];
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine("Введите элемент:");
    mass[i] = Console.ReadLine();
}

Console.Write("[ ");
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].Length < 4)
    {
        Console.Write(mass[i] + " ");
    }
}
Console.Write("]");


