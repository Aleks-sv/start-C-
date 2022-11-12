// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите начальное число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int numberLast = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int numFirst, int numLast)
{
    if (numFirst == numLast) Console.Write($"{numFirst}");
    if (numFirst < numLast)
    {
        Console.Write($"{numFirst} ");
        NaturalNumber(numFirst + 1, numLast);
    }
    if (numFirst > numLast)
    {
        Console.Write($"{numFirst} ");
        NaturalNumber(numFirst - 1, numLast);
    }
    
}
NaturalNumber(numberFirst, numberLast);
