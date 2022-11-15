// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = CreateMatrixRndInt(5, 3, 0, 5);
PrintMatrix(matrix);
Console.WriteLine();
int[] findSumElementsInColumns = FindSumElementsInColumns(matrix);
PrintArray(findSumElementsInColumns);
Console.WriteLine();
PrintMaxSumElementsInColumns(findSumElementsInColumns);


void PrintMaxSumElementsInColumns(int[] array)
{
    int minElement = array[0];
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(minElement > array[i]) 
        {
            minElement = array[i];
            count = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {count + 1} строке");
}

int[] FindSumElementsInColumns(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            array[i] = sum;
        }
    }
    return array;
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