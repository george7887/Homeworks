Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 1 || x >7)
{
    Console.Write("Нет такого дня недели, попробуйте еще: ");
    x = Convert.ToInt32(Console.ReadLine());
}

if (x == 6 || x == 7)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
