// Блок 2. В массив добавляется элемент в начало.
int[] array = { 3, 78, 9, 234 };
int l = array.Length;
int newL = l + 1;
int[] newArray = new int[newL];
int ind = 1;
newArray[0] = new Random().Next(1, 18);
Console.WriteLine(newArray[0]);
while (ind < newL)
{
    newArray[ind] = array[ind-1];
    Console.WriteLine(newArray[ind]);
    ind++;
}

