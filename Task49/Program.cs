// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }


}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //i +=2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// j += 2
        {
            if (i % 2 == 0 && j % 2 == 0)//remove
            {
                matrix[i, j] *= matrix[i, j];
            }
        }

    }
}



int[,] matr = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
ChangeMatrix(matr);
PrintMatrix(matr);