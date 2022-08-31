// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void PrintArray(double [,] matr) // Метод распечатки массива
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
void FillArraay (double [,] matr) // Заполение массива случайными числамии
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToDouble(new Random ().Next(-100,100))/10;

        }
    }
}
Console.Write("Ввседите количество строк массива (m): ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write("Ввседите количество столбцов массива (n): ");
int n = Convert.ToInt32 (Console.ReadLine());
double [,] matrix = new double [m,n];
FillArraay (matrix);
PrintArray(matrix);
