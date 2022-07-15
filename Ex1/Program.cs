/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();
System.Console.Write("Введите количество строк массива ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите длину строки массива ");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Convert.ToDouble((new Random().Next(-999,999))/10.0);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]} ");

    }
    System.Console.WriteLine();
}


