// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

SortSecondDigit(number);

void SortSecondDigit(int num)
{
    int secondDigit = 0;

    if (num >= 100 && num < 1000)
    {
        int firstDigit = num / 100;
        int thirtDigit = num % 10;
        secondDigit = (num - firstDigit * 100 - thirtDigit) / 10;
        Console.WriteLine($"{number} -> {secondDigit}");
    }
    else
        Console.WriteLine($"{number} - не трехзначное число!");
}