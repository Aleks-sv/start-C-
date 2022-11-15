// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 6);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = CreateArray(matrix);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
CountElements(array);


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
    Console.Write("]");
}

void CountElements(int[] array)
{
    int maxElement = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == maxElement) count++;
        else
        {
            Console.WriteLine($"{maxElement} встречается в массива {count} раз");
            maxElement = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{maxElement} встречается в массива {count} раз");
}

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    Array.Sort(array);
    return array;
}