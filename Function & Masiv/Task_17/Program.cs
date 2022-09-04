Console.WriteLine("Enter first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter secend number: ");
int y = Convert.ToInt32(Console.ReadLine());
while (x == 0 || y == 0)
{
    Console.WriteLine("ValueError!!");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
}
if (x > 1 && y > 1) 
    Console.WriteLine("1");
if (x < 1 && y > 1) 
    Console.WriteLine("2");
if (x > 1 && y < 1) 
    Console.WriteLine("3");
if (x < 1 && y < 1) 
    Console.WriteLine("4");
