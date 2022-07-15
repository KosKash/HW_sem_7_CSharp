/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.Clear();
System.Console.Write("Введите адрес элемента массива 'xx' ");
string id = Console.ReadLine();
int[] idMass = new int[2];
for (int i = 0; i < idMass.Length; i++) idMass[i] = int.Parse(id[i].ToString());
int high = idMass[0];
int length = idMass[1];
int[,] array = new int[,]
{
{ 2, 10, 8, 9 },
{ 6, 5, 10 , 22},
{ 10, 9, 8, 15},
};
System.Console.WriteLine("Массив ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");

    }
    System.Console.WriteLine();
}

if (high > array.GetLength(0)-1 || length > array.GetLength(1)-1)
    System.Console.WriteLine("Данного элемента массива нет");
else System.Console.WriteLine($"Заданный элемент массива - {array[high, length]}");
