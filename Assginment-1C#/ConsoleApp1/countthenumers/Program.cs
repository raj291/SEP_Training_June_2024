﻿// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j <= 24;)
    {
        Console.Write($" {j}");
        j = j + i;
    }
    Console.WriteLine();
}