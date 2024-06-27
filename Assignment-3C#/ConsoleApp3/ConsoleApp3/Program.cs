
using ConsoleApp3;

// GenerateNumbers gn = new GenerateNumbers();
// int[] numbers = gn.GenerateNumber(10);
// gn.Reverse(numbers);
// gn.PrintNumbers(numbers);
// Console.WriteLine("Enter the Number to find its Fibonacci Value");
// FibonacciSeq fs = new FibonacciSeq();
// int range;
// while (!int.TryParse(Console.ReadLine(), out range) || range <= 0)
// {
//     Console.WriteLine("Invalid input. Please enter a positive integer greater than zero:");
// }
// int seq = fs.Fibonacci(range);
// Console.WriteLine($"{seq}");

// ConceptOops ops = new ConceptOops();
// int some = ops.PolyMorphismExample(7,3);
// InheritedOops inops = new InheritedOops();
// double thing = ops.PolyMorphismExample(2.4, 1.5);
// int value = inops.PolyMorphismExample(10 , 3);
// ops.InterfaceExample();
// string FullName = "Hello";
// string name = ops.EncapuslationExample(FullName);
// Console.WriteLine(some);
// Console.WriteLine(thing);
// Console.WriteLine(value);
// Console.WriteLine(name);
int pid = 2;
string pname = "Raj";
string pcourse = "Math";
double pgpa = 3.3;
DateTime birthDate = new DateTime(1999, 12, 1);
Student student = new Student( pid , pname , pcourse , pgpa);
student.AddAddress("123 Main St");
Console.WriteLine("There are the Details for Students");
student.PrintDetails(birthDate);
int did = 40;
string dname = "Srijaya";
string dcourse = "Math"; 
decimal dsalary = 50000;
DateTime DbirthDate = new DateTime(1998, 5,1);
Department instructor = new Department(did , dname , dcourse, dsalary);
instructor.AddAddress("Dubai Uae");
Console.WriteLine("Instructor Details");
instructor.PrintDetails(DbirthDate);