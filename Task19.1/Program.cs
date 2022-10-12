// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CheckPalindrom(int num)
{
    int invertedNumber = default; //Создаем переменную которя будет перевернутым числом заданного
    int temporaryNumber = default; //Временнвя переменная
    while (num > 0)
    {
        temporaryNumber = num % 10;
        num = num / 10;

        invertedNumber = invertedNumber * 10 + temporaryNumber;
    }
    return invertedNumber;
}

if (number == CheckPalindrom(number)) Console.WriteLine($"Число {number} палиндром");
else Console.WriteLine($"Число {number} не палиндром");