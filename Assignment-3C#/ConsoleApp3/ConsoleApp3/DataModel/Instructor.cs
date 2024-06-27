using System.Diagnostics;
using ConsoleApp3.Interface;

namespace ConsoleApp3;

public class Instructor : Person , IPersonService
{
    public string Subject { get; set;}
    public decimal Salary { get; set;}
    public Instructor(int id, string name , string subject , decimal salary ) : base(id , name)
    {
        Subject = subject;
        Salary = salary;
    }
}

public class Department : Instructor
{
    public string DPname { get; set; }
    
    public Department( int id , string name , string subject , decimal salary ) : base(id, name , subject , salary)
    {
        DPname = GetDepartmentName(subject);
    }

    private string GetDepartmentName(string subject)
    {
        switch (subject)
        {
            case "Math":
                return "Engineering";
                break;
            case "History":
                return "Arts";
                break;
            default:
                return "No Department ";
                break;
        }
    } 
    public override void PrintDetails(DateTime birthDate)
    {
        base.PrintDetails(birthDate);
        Console.Write($" Subject : {Subject}, Department Name : {DPname} , Salary : {Salary} ");
        
    }
    
}

