Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int resiedue = a % 2;
if (resiedue == 1)
{
    Console.Write("число является нечётным");
}
else
{
    Console.Write("число является чётным");
}