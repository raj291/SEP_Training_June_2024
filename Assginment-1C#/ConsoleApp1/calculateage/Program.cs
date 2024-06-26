// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Date of Birth Year :");
int dob = int.Parse(Console.ReadLine());
DateTime date = DateTime.Now;
int years =  date.Year - dob;
int days = dob * 365;
Console.WriteLine($"You are {years} Old");
int daysToNextAnniversary = 10000 - (days % 10000);
Console.WriteLine($"Next Anniversary : {daysToNextAnniversary}");
