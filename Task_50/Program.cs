//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
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
Random rnd = new Random();
//Console.Write("Ввседите количество строк массива (m): ");
int m = rnd.Next(1,10);
//Console.Write("Ввседите количество столбцов массива (n): ");
int n = rnd.Next (1,10);
int[,] matrix = new int[m, n];
FillArraay(matrix);

Console.Write("Введите строку искомого эл-та: ");
int mserch = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец искомого эл-та: ");
int nserch = Convert.ToInt32(Console.ReadLine());


if (mserch >= matrix.GetLength(0) &&  mserch>= matrix.GetLength(1))
    {
    Console.WriteLine("\nЭлемента с заданной позицией не существует");
    }
else 
    {
    Console.WriteLine("\nЧисло с заданной позицией - " + matrix[mserch,nserch]);
    }
Console.Write("\nСлучайный масиив:\n");
PrintArray(matrix);
Console.WriteLine();