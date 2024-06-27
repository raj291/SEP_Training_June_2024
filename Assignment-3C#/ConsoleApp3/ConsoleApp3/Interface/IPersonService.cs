namespace ConsoleApp3.Interface;

public interface IPersonService
{
    int Age(DateTime birthDate);
    List<string> FindAddress();
}