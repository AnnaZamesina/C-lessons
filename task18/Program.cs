// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string Range(int number)
{
    if (number == 1) return "x > 0, y > 0";
    if (number == 2) return "x < 0, y > 0";
    if (number == 3) return "x < 0, y < 0";
    if (number == 4) return "x > 0, y < 0";
    return "Некорректный ввод данных";

}

string range = Range(quarter);

Console.WriteLine(range);