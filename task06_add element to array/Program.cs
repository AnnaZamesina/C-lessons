// В массив добавляется элемент в конец
int [] array = {3, 78, 9, 234};
int l1 = array.Length;
int l2 = l1+1; 
int [] largerArray = new int [l2];
int count = 0;
while (count<l1)
{
    largerArray [count] = array [count];
    Console.WriteLine(largerArray [count]);
    count++;
}
largerArray [l1] = new Random().Next (1,10);
Console. WriteLine (largerArray [l1]);





