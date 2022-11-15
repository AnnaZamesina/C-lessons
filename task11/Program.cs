// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число из отрезка (100,999): {number}");
int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdtDigit = num % 10;
    return firstDigit *10+thirdDigit;
}

int result = DeleteSecondDigit(number);
Console.WriteLine ($"двузначное число: {result}");
