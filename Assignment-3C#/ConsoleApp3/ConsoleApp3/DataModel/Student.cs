using ConsoleApp3.Interface;

namespace ConsoleApp3;

public class Student : Person , IStudentService
{
    public string Course { get; set; }
    public double Gpa { get; set;}
    public Student(int id, string name, string course, double gpa) : base(id , name)
    {
        
        Course = course;
        Gpa = gpa;
    }

    public string CalculateGrade(double gpa)
    {
        string grade = "";
        if (gpa >= 3.9)
        {
            
            grade = "A+";
        }
        else if (gpa >= 3.6 && gpa <= 3.8)
        {
            grade = "A";
        }
        else if (gpa >= 3.3 && gpa <= 3.5)
        {
            grade = "B";
        }
        else if (gpa >= 3.0 && gpa <= 3.2)
        {
            grade = "C";
        }
        else
        {
            grade = "D";
        }

        return grade;
    }
    public override void PrintDetails(DateTime birthDate)
    {
        base.PrintDetails(birthDate);
        Console.Write($" ,Course : {Course} , Grade : {CalculateGrade(Gpa)}");
    }
    
}