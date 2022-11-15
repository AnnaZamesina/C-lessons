// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool Multyplicity (int num1, int num2)
{
    return num1%num2==0;
}
Console.WriteLine ($"{Multyplicity(number1, number2)}, остаток = {number1%number2}");

// int MultyplicitySecond (int num1, int num2)
// {
//     return num1%num2;
// }
// int result2 = MultyplicitySecond (number1, number2);
// Console.WriteLine ($"Остаток от деления: {result2}");