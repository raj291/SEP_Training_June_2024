using EntityFramework.Core.Entities;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Repository;
using EntityFramework.Infrastructure.Services;

namespace EntityFramework.Presentation.UI;

public class ManageDepartment
{
    private DepartmentServices _departmentServices = new DepartmentServices();

    private void AddDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Department department = new Department();
        Console.WriteLine("Enter Department Name");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter the Location");
        department.Location = Console.ReadLine();
        Console.WriteLine(_departmentServices.AddDepartment(departmentRequestModel));
    }
    
    private void DeleteDepartment()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentServices.DeleteDepartmentBy(id);
    }
    private void UpdateDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Department department = new Department();
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name =>");
        department.DepartmentName = Console.ReadLine();
        Console.WriteLine("Enter Location =>");
        department.Location = Console.ReadLine();
        Console.WriteLine(_departmentServices.UpdateDepartment(id, departmentRequestModel));
    }
    
    private void PrintAll()
    {
        var departments = _departmentServices.GetAllDepartments();
        foreach (var department in departments)
        {
            Console.WriteLine(department.DepartmentName + "\t" + department.Location);
        }
    }
    private void PrintById()
    {
        Console.WriteLine("Enter Id =>");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentServices.GetById(id);
        Console.WriteLine(id + "\t" + department.DepartmentName + "\t" + department.Location);
    }

    public void Run()
    {
        DeleteDepartment();
        PrintAll();
    } 
}