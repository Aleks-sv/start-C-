// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] NewArray (int[] array)
{
    //int size = array.Length / 2;
    //if (size % 2 == 1) size = size + 1;
    int[] newArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    //if (array.Length % 2 == 1) newArray.Length - 1 = array.Length - 1;
    return newArray;

}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
int[] newArray = NewArray(arr);
PrintArray(newArray);