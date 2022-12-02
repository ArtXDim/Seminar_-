/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите число а=");
int numA = Console.ReadLine(Convert.ToInt32(numA));
Console.Write("Введите число b=");
int numB = Console.ReadLine(Convert.ToUInt32(numB));

/*
for (int i = 0; i < 3; i++)
{
    var a = GetRightNumber("a");
    var b = GetRightNumber("b");
    var max = Math.Max(a, b);
    var min = Math.Min(a, b);

    if (max == min)
    {
        Console.WriteLine("Ха ха числа то одинаковые, ты меня хочешь обмануть");
    }
    else
    {
        Console.WriteLine($"{max}, больше чем {min}");
    }
}

static int GetRightNumber(string name)
{
    Console.Write($"Введите число {name}=");
    int b = 0;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Так вводить надо числа, Дурень!!!");
        continue;
    }
    return b;
}
*/