// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    var matrix = new int[rows, colums];
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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] FindMinMaxIndex(int[,] matrix)
{
    int minElement = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= minElement)
            {
                minElement = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { minElement, minRow, minColumn };
}

int[,] CreateResultMatrix(int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            //matrix[i, j] = matrix[i, j];
            if (array[1] == matrix.GetLength(i))
            {
               matrix[i, j] = matrix[matrix.GetLength(i), j];
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrixRndInt(3, 3, 0, 6);
PrintMatrix(matrix);
Console.WriteLine();
int[] findMinMaxIndex = FindMinMaxIndex(matrix);
PrintArray(findMinMaxIndex);
Console.WriteLine();
int[,] resultMatrix = CreateResultMatrix(matrix, findMinMaxIndex);
PrintMatrix(resultMatrix);