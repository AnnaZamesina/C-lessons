// See https://aka.ms/new-console-template for more information
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int [] array = new int [8];
// array [i] = new Random().Next (1,10);

// int[] array = new int[8];

// void Random(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(0, 2);
//         Console.Write($"{col[i]} ");
//     }
// }
int[] array = new int[8];

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

RandomArray(array);

// Console.WriteLine(string.Join(" ", array));
PrintArray(array);

