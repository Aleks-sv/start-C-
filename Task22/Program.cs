// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square (int num)
{
    int count = 1;
    while (count <= num)
{
    int square = count * count;
    Console.WriteLine($"{count}     {square}");
    count++;
}
}

// void SquareTable(int num)
// {
//     int index = 1;
//     Console.WriteLine($"Таблица квадратов чисел от 1 до {num}");
//     while (index <= num)
//     {
//         Console.WriteLine($"|{index,4}|{Math.Pow(index, 2),4}|");
//         index++;
//     }
// }


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// SquareTable(number);