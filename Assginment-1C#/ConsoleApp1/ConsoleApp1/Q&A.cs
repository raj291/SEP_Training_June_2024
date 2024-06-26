// See https://aka.ms/new-console-template for more information

// A person’s telephone number
long phoneNo = 3134567891;
Console.WriteLine($"The Phone Number is ({phoneNo}) ");
//A person’s height
int height = 178;
Console.WriteLine($"Height is {height} Cm");
// A Persons Age
int age = 25;
Console.WriteLine($"Age is {age} years old ");
// A Person Gender
char gender = 'M';
Console.WriteLine($"Gender is {gender}");
// A Persons Salary
decimal salary = 2400.30m;
Console.WriteLine($"Salary is {salary}");
// A Books ISBN
long isbn = 9783161484100;
Console.WriteLine($"The ISBN of a Book is {isbn}");
// Price of a book
decimal price = 234.13m;
Console.WriteLine($"Price of the book is ${price}");
//Weight of a Book
float weight = 1.4f;
Console.WriteLine($"Shipping book Weight is {weight} lbs");
uint popu = 1428627663;
// Population of a Country 
Console.WriteLine($"Population of a Country is {popu} People");
// Number of Stars in the Universe
ulong stars = 2000000000000000000;
Console.WriteLine($"Number of Stars in the Universe are {stars}");
Console.WriteLine("############################################################");
//Number of Employees in a Business
ushort emp = 50000;
Console.WriteLine($"Range of Employees in Small or Medium Business are around {emp} per Business");
Console.WriteLine("############################################################");
/* What are the differences Between Value Type and Reference Type Varirable */
Console.WriteLine($"The main Difference is that :"); 
Console.WriteLine("1 .Value Type Directly Holds the Value, While References Holds the Memory address of the Value");
Console.WriteLine("2 .Value types are stored in Stack , While Reference are in Heap Memory");
Console.WriteLine("3. Value types are not collected in Garbage Collection, Reference Type are.");
Console.WriteLine("4. Value Types cannot accept null values(Using ? to make it Nullable), Reference type can");
Console.WriteLine("############################################################");
int? e = null;
object wg = null;
// What is Boxing and Unboxing? 
Console.WriteLine("Boxing means Converting value type to references type and Unboxing is the otherway around");
bool t = true;
object o = t;
Console.WriteLine(o);
bool j = (bool)o;
Console.WriteLine("############################################################");
// What is meant by the terms managed resource and unmanaged resource in .NET
Console.WriteLine("The Heap Memory is Divided Into Two Parts : Managed Heap and Unmanaged Heap");
Console.WriteLine("Managed Heap Contains the 3 Tiers which is used for garabage collection Which are 0 , 1 ,2.");
Console.WriteLine("All the Reference type are stored in these the Managed Heap Parts and cannot be called Manually");
Console.WriteLine("Unmanaged Heap we have file Transformation and Database connections. Which needs to be cleared manually by the dispose()");
Console.WriteLine("############################################################");
// Whats the purpose of Garbage Collector in .NET?
Console.WriteLine("Garbage Collector is provided by the CLR to automatically Manage its memory during runtime. Garbage only works for the Reference type and stores its and not the value type");
Console.WriteLine("############################################################");
// What happens when you divide an int variable by 0?
//int a = 6;
//int b = a/0;
//Console.WriteLine(b);
Console.WriteLine("When dividing any int value with 0 , an Exception is Throw which is DividedByZeroException. As Division by Zero is not allowed");
Console.WriteLine("############################################################");
// What happens when you divide a double variable by 0?
double c = 10;
//double d = 10/0;
Console.WriteLine("Before Running the Code .Net Framework Shows an Error which tells That Arithmetic problem in constant value computation ");
Console.WriteLine("############################################################");
//What happens when you overflow an int variable, that is, set it to a value beyond its range?
//int ete = 111111110000011042;
Console.WriteLine("It will give a pre compiled error saying :Cannot convert source type 'long' to target type 'int'");
Console.WriteLine("############################################################");
int x = 0;
int y = x++;
Console.WriteLine(y); 
y = ++x;
Console.WriteLine(y);
Console.WriteLine("1 . x++ implies Post Increment which means it will assign the value to x then increment");
Console.WriteLine("2 . ++x implies Pre Increment which means it will increment first then assgin the value");
Console.WriteLine("############################################################");
// What is the difference between break, continue, and return when used inside a loop statement?
Console.WriteLine("1. Break gets out of the loop once the condition is statisfied");
Console.WriteLine("2. Continue will iterate in the loop but skip the remaining code after the continue statement if the condtion is satisfied");
Console.WriteLine("3. Return is used to exit from a method or a function and return some kind of value");
Console.WriteLine("############################################################");
//What are the three parts of a for statement and which of them are required?

Console.WriteLine("The Three main parts of for loop are :");
Console.WriteLine("Initialization : Used to create a starting point for the loop for it iterate from. It is required as the program would not know where to start");
Console.WriteLine("Condition : It is used to determine how long will the for loop will iterate. it is required as well");
Console.WriteLine("iteration : It is used to tell the for loop in what way should it increment in. This part is not required");
Console.WriteLine("############################################################");
//What is the difference between the = and == operators?
Console.WriteLine("The Difference between = and == : = is used to change or assign the state of the value While == is used to compare the value");
Console.WriteLine("############################################################");
// Does the following statement compile? for ( ; true; ) ;
Console.WriteLine("It will run the code infinite times Unless manually Stopped");
// What does the underscore _ represent in a switch expression?
Console.WriteLine(" The _ acts as a Default Switch case in C#");
// What interface must an object implement to be enumerated over by using the for each statement?
