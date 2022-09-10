Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int c = 0;
while (x != 0)
{
    c = c + x % 10;
    x = x / 10;
}
Console.WriteLine(c);