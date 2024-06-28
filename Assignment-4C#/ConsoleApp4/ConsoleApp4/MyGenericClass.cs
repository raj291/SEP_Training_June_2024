namespace ConsoleApp4;

public class MyGenericClass<T>
{
    private string _name = "Raj";

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}