// See https://aka.ms/new-console-template for more information

int h = 4;
for (int i = 1; i <= h; i++)
{
    for (int j = i; j < h; j++)
    {
        Console.Write("#");
    }

    for (int k = 1; k <= (2 * i - 1); k++)
    {
        Console.Write("*");
        
    }
    Console.WriteLine();
}