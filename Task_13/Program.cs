Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x / 100 == 0)
{
    Console.WriteLine("Попробуйте еще раз: ");
    x = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(x % 1000 / 100);
