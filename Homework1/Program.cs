/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitMatrix(int m, int n)
{
    Console.Write("Введите минимально возможное значение случайного числа: ");
    double min = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите максимально возможное значение случайного числа: ");
    double max = double.Parse(Console.ReadLine() ?? "");
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите колличество строк в матрице: ");
int n = GetNumber("Введите колличество столбцов в матрице: ");
double[,] matr = InitMatrix(m, n);
PrintMatrix(matr);
