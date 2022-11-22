// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitAmount(int num)
{
    int count = 0;
    if (num < 0) num = -num;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}

int result = DigitAmount(number);
Console.WriteLine($"Количество цифр в числе: {result}");

// Console.Writeline(Math.Abs(-123));
