// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = CreateMatrixSpiralInt(3, 3);
PrintMatrix(matrix);

int[,] CreateMatrixSpiralInt(int rows, int columns)
{
    var matrix = new int[rows, columns];
    int firstNumber = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // int t = 0;
            // int n = matrix.GetLength(0);
            // int m = matrix.GetLength(1);
            // while (firstNumber <= matrix.Length)
            // {
            //     for (i = t; i < n; i++) matrix[j, i] = firstNumber++;
            //     j = n - 1;
            //     for (i = t + 1; i < m; i++) matrix[i, j] = firstNumber++;
            //     j = m - 1;
            //     for (i = n - 2; i >= t; i--) matrix[j, i] = firstNumber++;
            //     j = t;
            //     for (i = m - 2; i > t; i--) matrix[i, j] = firstNumber++;
            //     n--;
            //     m--;
            //     t++;
            //     j = t;
            // }
           for (int k = 0; k < matrix.Length; k++)
           {
                matrix[i, j] = firstNumber++;
           }
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