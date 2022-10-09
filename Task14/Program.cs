// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

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