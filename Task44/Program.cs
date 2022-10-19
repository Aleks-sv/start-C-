// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindFibonatchi(number);
void FindFibonatchi(int num)
{
    int firstNumber = 0;
    int secondNumber = 1;
    Console.Write($"{firstNumber} {secondNumber} ");
    for (int i = 0; i < num; i++)
    {
        int nextNumber = 0;
        nextNumber = nextNumber + firstNumber + secondNumber;
        Console.Write($"{nextNumber} ");
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
}


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Fibonacci(int num)
// {
//     int firstNumber = 0;
//     int secondNumber = 1;
//     Console.Write($"{firstNumber} {secondNumber} ");
//     for (int i = 0; i < num-2; i++)
//     {
//         int nextNumber = firstNumber + secondNumber;
//         Console.Write($"{nextNumber} ");
//         firstNumber = secondNumber;
//         secondNumber = nextNumber;
//     }
// }

// Fibonacci(number);