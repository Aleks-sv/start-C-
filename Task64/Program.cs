// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrindNaturalNumber(int number)
{
    if (number == 0) return;
    Console.Write($"{number} ");
    PrindNaturalNumber(number - 1);
}

PrindNaturalNumber(number);