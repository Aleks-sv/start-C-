// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matr = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(matr);
Console.WriteLine();

bool findPositionElement = FindPositionElement(matr, row, column);
if (findPositionElement) Console.WriteLine($"{FindElement(matr, row, column)}");
else Console.WriteLine("Такого элемента в массиве нет.");

int FindElement(int[,] matrix, int row, int column)
{
    int findElement = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row - 1 && j == column - 1) findElement = matrix[i, j];
        }
    }
    return findElement;
}

bool FindPositionElement(int[,] matrix, int row, int column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == row - 1 && j == column - 1) return true;
            }
        }
    }
    return false;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}