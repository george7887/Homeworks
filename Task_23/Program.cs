﻿Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
