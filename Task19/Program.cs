// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

CheckPalindrome(number);

void CheckPalindrome(int num)
{
    if (num >= 10000 && num < 100000)
    {
        int firstDigit = num / 10000;
        int secondDigit = (num % 10000) / 1000;
        int fourthDigit = (num % 100) / 10;
        int fifthDigit = num % 10;

        if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine($"Число палиндром.");
        else Console.WriteLine("Число не палиндром.");
    }
    else Console.WriteLine("Число не пятизначное!");
}