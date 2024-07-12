using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageEmployee
{
    private EmployeeService _employeeService = new EmployeeService();

    private void AddEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Please Enter Employee Name");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("Please Enter Employee Age");
        employeeRequestModel.Age= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.AddEmployee(employeeRequestModel));
    }

    private void PrintAllEmployee()
    {
        var employees = _employeeService.GetAllEmployee();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.EmployeeName + "\t" + employee.Age);
        }
    }

    private void GetEmployeeId()
    {
        Console.WriteLine("Please Enter Employee Id");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _employeeService.GetById(id);
        Console.WriteLine(employee.EmployeeName + "\t" + employee.Age);

    }

    private void UpdateEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Enter your Employee Id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Employee Name");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("enter employee age: ");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.UpdateEmployee(id , employeeRequestModel));
    }

    private void DeleteEmployee()
    {
        Console.WriteLine("Please Employee Id to Delete");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(_employeeService.DeleteEmployeeById(id));
    }

    public void Run()
    {
        DeleteEmployee();
        PrintAllEmployee();
    }
}