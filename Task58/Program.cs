// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixFirst = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(matrixSecond);
Console.WriteLine();

int[,] resuilMatrix = MultiplicationTwoMatrixs(matrixFirst, matrixSecond);
if (matrixFirst.GetLength(0) == matrixSecond.GetLength(1)) PrintMatrix(resuilMatrix);
else Console.WriteLine("Перемножение двух матриц невозможно!");



int[,] MultiplicationTwoMatrixs(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixOne[i, k] * matrixSecond[k, j];
            }
        }
    }
    return resultMatrix;
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