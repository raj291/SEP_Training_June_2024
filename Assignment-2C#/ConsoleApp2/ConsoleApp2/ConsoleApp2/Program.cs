// See https://aka.ms/new-console-template for more information
// When to use String vs StringBuilder in C#

using ConsoleApp2;

Console.WriteLine("The String reference type,however String is immutable and cannot be used to hold variable character in C#. " +
                  "In Order create a Mutable String C# Provides us with StringBuilder Which is mutable and follows  all the Characteristics of String");
Console.WriteLine("The are different situations to use String and StringBuilder. " +
                  "String is Immutable so we can use store sensitive data." +
                  " When require you can convert String into String type whenever required ");
Console.WriteLine("##############################################################################");
//What is the base class for all arrays in C#?
Console.WriteLine("System.Array is the base class for all arrays in C#. Where System.array is a built-in class.");
Console.WriteLine("##############################################################################");
//How do you sort an array in C#?
Console.WriteLine("There are various efficient way to sort an array using different algorithm.");
Console.WriteLine(" However, Like many other languages C# has its own function which is called Array.Sort();");
Console.WriteLine("##############################################################################");
// What property of an array object can be used to get the total number of elements in an array?
Console.WriteLine("To get the total number of Elements in an array. We can use .Length property");
Console.WriteLine("##############################################################################");
//Can you store multiple data types in System.Array?
Console.WriteLine("System.Array is used to store values of a single data type and cannot be used to store multiple types.");
Console.WriteLine("As it is initialized by first providing the datatype then array symbol int[] or string[]");
Console.WriteLine("##############################################################################");
//What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
Console.WriteLine("CopyTo() is used to Copy elements of an existing array into a different or new array. However it is not necessary for the length of the array to be same");
Console.WriteLine("Clone() is used to create an exact duplicate of the original array as a new array. Here both values and length of the array is same");
Console.WriteLine("##############################################################################");


FindPrime p = new FindPrime();
int[] pri = p.FindPrimesInRange(4,40);
Console.WriteLine(string.Join(", ",pri));
Console.WriteLine("##############################################################################");
RotateK rk = new RotateK();
int[] arr = { 3,2,4,-1};
int num = 2;
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", rk.Rotate(arr,num)));
Console.WriteLine("##############################################################################");
LongSequence ls = new LongSequence();
int[] arr2 = { 1, 3, 5, 1, 1, 1, 3, 3 };
Console.WriteLine(string.Join(", ", ls.FindLong(arr2)));
Console.WriteLine("##############################################################################");
Console.Write("Enter the string or word to Reverse");
string input = Console.ReadLine();
ReverseString rs = new ReverseString();
string output = rs.Reverse(input);
Console.WriteLine(output);
bool check = rs.IsPalindrome(output, input);
Console.WriteLine(check);
Console.WriteLine("##############################################################################");
Console.WriteLine("Enter the SentenceA for Palindrome only word");
string sentence = Console.ReadLine();
string Palsen = PalindromeSentence.FindAndSortPalindromes(sentence);
Console.WriteLine(Palsen);
Console.WriteLine("##############################################################################");
ProtocolRetriver pr = new ProtocolRetriver();
string inw = Console.ReadLine();
string[] ryr = pr.SpiltPro(inw);
Console.WriteLine(ryr);
