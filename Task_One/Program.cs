Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("большее число - ");
    Console.Write(a);
    Console.Write(", меньшее число - ");
    Console.WriteLine(b);
}
else
    if (a < b)
    {
        Console.Write("большее число - ");
        Console.Write(b);
        Console.Write(", меньшее число - ");
        Console.WriteLine(a); 
    }
    else
    {
        Console.Write("числа равны");
    }
