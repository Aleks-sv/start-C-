// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}-e число = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int FindPositiveNumbers(int[] array)
{
    int numbers = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) numbers += 1;
    }
    return numbers;
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

int findPositiveNumbers = FindPositiveNumbers(array);
PrintArray(array);
Console.Write($" -> {findPositiveNumbers}");


