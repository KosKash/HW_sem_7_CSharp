/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();
int[,] array = new int[,]
{
{1,3,6,9},
{5,6,7,1},
{8,4,5,8}
};// задан сам массив
double[] srAr = new double[array.GetLength(1)]; // инициализация массива в котором хран. ср. ар чисел
for (int j = 0; j < array.GetLength(0); j++)
{
    for (int i = 0; i < srAr.Length; i++) srAr[i] += array[j, i]; // сумма столбиков массива
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
    System.Console.WriteLine(); // вывод массива в консоль
}
System.Console.WriteLine(); // разделительная строка
for (int i = 0; i < srAr.Length; i++)
{
    srAr[i] = srAr[i] / array.GetLength(0); // нахождение ср. ар. и вывод в консоль
    System.Console.WriteLine($"Ср. ариф столбика {i + 1} = {srAr[i]}");
}

