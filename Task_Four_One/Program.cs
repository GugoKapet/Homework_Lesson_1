Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int even;
while (count <= number)
{
    if (count % 2 == 0)
    {
        even = count;
        Console.WriteLine(even + ", ");
    }
    count++;
}