// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the number !");
int guessedNumber = int.Parse(Console.ReadLine());
int correctNumber = new Random().Next(3) + 1;
if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("Number out fo the Guessing Range");
}
else if (correctNumber > guessedNumber )
{
    Console.WriteLine("Higher");
    
}
else if (correctNumber < guessedNumber)
{
    Console.WriteLine("Lower");
}
else if (correctNumber == guessedNumber)
{
    Console.WriteLine("Correct Guess!");
}

