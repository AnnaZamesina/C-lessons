// Блок 3. В массив добавляется элемент в позицию (допустим 4).
int [] array = { 3, 78, 9, 234 };
int l = array.Length;
int count = 0;
Console.WriteLine("Введите номер позиции");
int position = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine();
while (count<l)
{
    if (count == position) array[count]=4;
    Console.WriteLine(array[count]);
    count++;
}
