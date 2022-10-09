// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Enter digit: ");
int number = Convert.ToInt32(Console.ReadLine());

bool CheckMultiple(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
if (CheckMultiple(number))
Console.WriteLine("yes");
else
Console.WriteLine("no");