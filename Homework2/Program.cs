/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int GetNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()??"");
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

void FindElement(int[,] matrix, int positionRow, int positionColumn)
{
    if (positionRow < matrix.GetLength(0) && positionColumn < matrix.GetLength(1))
    {
        int number = matrix[positionRow, positionColumn];
        Console.WriteLine($"Значение элемента равно {number}");
    }
    else
        Console.WriteLine("Такого элемента нет");
}

int row = GetNumber("Введите колличество строк в матрице: ");
int col = GetNumber("Введите колличество столбцов в матрице: ");
int min = GetNumber("Введите минимально возможное значение элементов матрицы: ");
int max = GetNumber("Введите максимально возможное значение элементов матрицы: ");
int[,] matrix = InitMatrix(row, col, min, max);
int posRow = GetNumber("Введите строку искомого элемента в матрице: ");
int posCol = GetNumber("Введите столбец искомого элемента в матрице: ");
PrintMatrix(matrix);
FindElement(matrix, posRow, posCol);
