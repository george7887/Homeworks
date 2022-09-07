Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x / 100 == 0) Console.WriteLine("Третьей цыфры нет!");
else
    Console.WriteLine(x % 1000 / 100);
