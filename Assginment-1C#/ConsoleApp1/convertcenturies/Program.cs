// See https://aka.ms/new-console-template for more information

Console.Write("INPUT: ");
uint centuries = uint.Parse(Console.ReadLine());
uint years = centuries * 100;
uint days = years * 365;
ulong hours = days * 24;
ulong minutes = hours * 60;
ulong seconds = minutes * 60;
ulong milliseconds = seconds * 1000;
ulong microseconds = milliseconds * 1000;
ulong nanoseconds = microseconds * 1000L;


Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
    centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);