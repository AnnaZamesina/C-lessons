// Заполнить массив случайными числами и вывести все элементы через 1


void PrintEachSenond (int [] col)
{
    int index = 0;
    int lenght = col.Length;
    
    while (index<lenght)
    {
        // col[index]=new Random().Next(1,10);
        Console.WriteLine(col[index]);
        index=index+2;
    }
}

void PrintArray (int [] collection)
{
    int ind = 0;
    int lenght = collection.Length;
    
    while (ind<lenght)
    {
        collection[ind]=new Random().Next(1,10);
        Console.WriteLine(collection[ind]);
        ind++;
    }
}

int [] array = new int [5];
PrintArray(array);
Console.WriteLine();
PrintEachSenond(array);


