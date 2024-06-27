using ConsoleApp3.Interface;

namespace ConsoleApp3;

public abstract class Person : IPersonService
{
    public int Id { get; set; }
    public string Name { get; set; }
    private List<string> addresses = new List<string>();
    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Age(DateTime birthDate)
    {
        int age = DateTime.Now.Year - birthDate.Year;
        return age;
    }

    public List<string> FindAddress()
    {
        return addresses;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }
    public virtual void PrintDetails(DateTime birthDate)
    {
        Console.Write($"Id : {Id} , Name : {Name} , Age {Age(birthDate)} ,Address :  ");
        Console.Write(string.Join(" ", FindAddress()));
    }
}