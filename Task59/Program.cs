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
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] FindMinElement(int[,] matrix)
{
    int minElement = matrix[0, 0];
    int minRow = 0;
    int minColum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= minElement) 
            {
            minElement = matrix[i, j];
            minRow = i;
            minColum = j;
            }
        }
    }
    return new int[] {minElement, minRow, minColum};
}

int[,] CreateResultMatrix(int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == && j == findMinElement[2]) matrix[i, j];
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 6);
PrintMatrix(matrix);
Console.WriteLine();
int[] findMinElement = FindMinElement(matrix);
PrintArray(findMinElement);
Console.WriteLine();
int[,] resultMatrix = CreateResultMatrix(matrix, findMinElement);
PrintMatrix(resultMatrix);
Console.WriteLine($"{findMinElement[0]}");
Console.WriteLine($"{findMinElement[1]}");
Console.WriteLine($"{findMinElement[2]}");