// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10,99]


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
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

int FindNumbers(int[] array)
{
    int sum = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (10 <= array[i] && array[i] <= 99) sum = sum + 1;
    }
    return sum;
}

int[] arr = CreateArrayRndInt(123, 0, 100);
PrintArray(arr);

Console.WriteLine(FindNumbers(arr));