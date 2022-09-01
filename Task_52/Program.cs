// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
using System;
void PrintArray(int[,] matr) // Метод распечатки массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // распечатать массив
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " "); // вывод массива
            //Console.Write(";");
        }

        Console.WriteLine();
    }
}
void FillArraay(int[,] matr) // Заполение массива случайными числамии
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToInt32(new Random().Next(1, 10));

        }
    }
}
Console.Clear();
Console.Write("Ввседите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввседите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());;
int[,] matrix = new int[m, n];
FillArraay(matrix);
Console.Write("\nМасиив:\n");
PrintArray(matrix);
Console.WriteLine();

for (int j = 0; j < matrix.GetLength(1); j++)
{    
    double sred = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sred = (sred + matrix[i,j]);
    }
    sred = sred/n;
    Math.Round(sred,2);
    Console.WriteLine("Среднее арифметическое значение элементов "+ (j+1)+ " столбца = " +sred);
}
