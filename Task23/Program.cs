// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

FindThirdDegree(number);

void FindThirdDegree(int num)
{
    Console.WriteLine($"Таблица чисел от 1 до {num} в третьей степени.");

    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5}  |{Math.Pow(count, 3),5}");
        count++;
    }
}