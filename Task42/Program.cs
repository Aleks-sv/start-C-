// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Ввкдите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Binary (int num)
{
    int temp = 0;
    int count = 1;
    while (num > 0)//45
    {
        temp = temp + num % 2 * count;//1
        num = num / 2;//22
        count = count * 10; //10
    }

    return temp;
}

int binary = Binary(number);
Console.WriteLine($"{number} -> {binary}");

