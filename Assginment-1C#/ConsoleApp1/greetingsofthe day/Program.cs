// See https://aka.ms/new-console-template for more information
DateTime currentTime = DateTime.Now;
int currentHour = currentTime.Hour;
if (currentHour >= 0 && currentHour < 12)
{
    Console.WriteLine("Good Morning");
}
if (currentHour >= 12 && currentHour < 16)
{
    Console.WriteLine("Good Afternoon");
}
if (currentHour >= 16 && currentHour < 21)
{
    Console.WriteLine("Good Evening");
}
if (currentHour >= 21 || currentHour < 5)
{
    Console.WriteLine("Good Night");
}