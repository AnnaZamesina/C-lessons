Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
if (number >=  0)
{
while (count <= number)
{
    Console.Write(count+" ");
    count++;
}
}
else 
{
   while (count >= number)
{
    Console.Write(count+" ");
    count--;
}
}
