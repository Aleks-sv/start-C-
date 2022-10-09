// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1000)
{
    int result = number;
    while (number > 1000)
    {
        number = number / 10;
    }
    int thirtDigit = number % 10;
    Console.WriteLine($"Третья цифра числа {result} -> {thirtDigit}");
}
else if (number >= 100 && number < 1000)
{
    int thirtDigit = number % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {thirtDigit}");
}
else Console.WriteLine("Третьего числа нет.");
