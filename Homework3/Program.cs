/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int row, int column, int minRnd, int maxRnd)
{
    int[,] resultMatrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++) resultMatrix[i, j] = rnd.Next(minRnd, maxRnd);
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
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

string ArithmeticMeanOfColumns(int[,] matrix)
{
    double average = 0;
    string result = "";
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
            sum += matrix[i, j];
        average = Math.Round(sum / matrix.GetLength(1),1);
        result += ($"{average.ToString()}; ");
    }
    return result;
}

int row = GetNumber("Введите колличество строк в матрице: ");
int col = GetNumber("Введите колличество столбцов в матрице: ");
int min = GetNumber("Введите минимально возможное значение элементов матрицы: ");
int max = GetNumber("Введите максимально возможное значение элементов матрицы: ");
int[,] matrix = InitMatrix(row, col, min, max);
PrintMatrix(matrix);
string res = ArithmeticMeanOfColumns(matrix);
Console.Write($"Среднее арифметическое каждого столбца: {res}");
