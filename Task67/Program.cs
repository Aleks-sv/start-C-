// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите начальное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumElement (int num)
{
    if (num == 0) return 0;
    return num % 10 + SumElement(num / 10);

}

int sumElement = SumElement(number);
Console.WriteLine($"{sumElement}");