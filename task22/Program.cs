// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 0) Console.WriteLine("некорректные данные");
}

string Sqrs(int num)
{
    int count = 1;
    string table = "";
    while (count <= num)
    {
        table = table + $"{count} {count * count}\n";
        count++;
    }
    return table;
}

Console.WriteLine(Sqrs(n));