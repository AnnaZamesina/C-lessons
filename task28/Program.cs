// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Multyplicity(int num)
{
    int multy = 1;
    for (int i = 1; i <= num; i++)
    {
       multy = multy * i; 
    }
    return multy;
}
int result = Multyplicity(number);
Console.Write ($"Произведение от 1 до N: {result}");

