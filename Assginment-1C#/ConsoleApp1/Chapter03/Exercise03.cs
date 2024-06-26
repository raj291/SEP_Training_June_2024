// See https://aka.ms/new-console-template for more information

int a = 100;
for (int i = 1; i <= a ; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizz Buzz");
    }
    else if (i%3 == 0)
    {
        Console.WriteLine("Fizz");
    }

    else if (i%5 == 0)
    {
        Console.WriteLine("Buzzz");
    }
    
    else
    {
        Console.WriteLine(i);
        
    }
}