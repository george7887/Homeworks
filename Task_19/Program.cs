Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x / 10000 == 0 || x / 100000 != 0)
{
    Console.WriteLine("Не верноб попробуйте еще раз: ");
    x = Convert.ToInt32(Console.ReadLine());
}

if (x / 10000 == x % 10 & x / 1000 % 10 == x % 100 / 10)
    Console.WriteLine("да"); 
else
    Console.WriteLine("нет");
