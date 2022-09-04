int x, i;
Console.WriteLine("Enter number: ");
x = Convert.ToInt32(Console.ReadLine());
/*int i = 1;
while (i <= x)
{
    int y = i * i;
    Console.Write(y + " ");
    i++;
}*/
for (i = 1; i <= x; i++)
{
    Console.Write(Math.Pow(i, 2) + " ");
}
