Console.WriteLine("Введите значение A: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B: ");
int y = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for (int i = 1; i <= y; i++)
{
    pow = pow * x;
}

Console.WriteLine(pow);