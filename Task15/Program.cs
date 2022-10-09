// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру для недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number <= 0)
    Console.WriteLine("Такого дня недели нет!");
else if (number == 6 || number == 7)
    Console.WriteLine($"{number} -> Да");
else
    Console.WriteLine($"{number} -> Нет");

