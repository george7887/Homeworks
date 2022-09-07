int t = 1, N = 0, y = 10;
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 10;t != 0; i = i * 10)
{
    t = x / i;
    N++;
}
if (x / 100 == 0) Console.WriteLine("Третьей цифры нет!");
else
    Console.WriteLine(x / Convert.ToInt32(Math.Pow(y, N-3)) % y);
