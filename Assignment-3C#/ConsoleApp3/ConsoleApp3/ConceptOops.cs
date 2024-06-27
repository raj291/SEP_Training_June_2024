namespace ConsoleApp3;

public class ConceptOops : Iops
{
    // Abstraction
    public string InterfaceExample()
    {
        string name = "Raj";
        Console.WriteLine("Abstraction Example");
        return name;
    }
    // Polymorphism 
    // Method Overloading
    public double PolyMorphismExample(double a, double b)
    {
        Console.WriteLine("MethodOverLoading");
        return a + b;
    }
    // Overriding Method 
    public virtual int PolyMorphismExample(int a, int b)
    {
        return a + b;
    }
    private string name;
    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public ConceptOops()
    {
        Name = name;
    }
    public string EncapuslationExample(string name)
    {
        return name;
    }
}
// Inheritance 
public class InheritedOops : ConceptOops
{
    public override int PolyMorphismExample(int c, int d)
    {
        Console.WriteLine("Method Overiding");
        return c - d;
    }
}