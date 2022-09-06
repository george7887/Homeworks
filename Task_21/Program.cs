Console.WriteLine("Введите x1, y1, z1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2, y2, z2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));