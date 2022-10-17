Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int residue = a % 2;
if (residue == 1)
{
    Console.Write("число является нечётным");
}
else
{
    Console.Write("число является чётным");
}