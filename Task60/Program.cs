// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] matrix3D = CreateMatrix3D(2, 2, 2);
PrintMatrix3D(matrix3D);

int[,,] CreateMatrix3D(int rows, int columns, int depth)
{
    int[,,] matrix3D = new int[rows, columns, depth];
    int min = 10;
    int max = 100;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                if (min < max) 
                {
                matrix3D[i, j, k] = min++;
                }
                else min = 10;
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                if (k < matrix3D.GetLength(2) - 1) Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}), ");
                else Console.Write($"{matrix3D[i, j, k]}({i},{j},{k})");
            }
            Console.Write("|");
        }
        Console.WriteLine();
    }
}
