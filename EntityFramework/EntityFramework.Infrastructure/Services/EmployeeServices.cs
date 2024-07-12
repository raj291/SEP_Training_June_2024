using EntityFramework.Core.Entities;
using EntityFramework.Core.Interface.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repository;
using Serilog;

namespace EntityFramework.Infrastructure.Services;

public class EmployeeService: IEmployeeServices
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();
    public List<EmployeeResponseModel> GetAllEmployee()
    {
        var employees = _employeeRepository.GetAll();
        var employeeResponseModels = new List<EmployeeResponseModel>();
        foreach (var employee in employees)
        {
            employeeResponseModels.Add(new EmployeeResponseModel
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age,
            });
        }

        return employeeResponseModels;
    }

    public EmployeeResponseModel GetById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee != null)
        {
            var employeeResponseModel = new EmployeeResponseModel
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age
            };
            return employeeResponseModel;
        }

        return null;
    }

    public int AddEmployee(EmployeeRequestModel model)
    {
        var employeeEntity = new Employee
        {
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentId = 1,
        }; 
        return _employeeRepository.Insert(employeeEntity);
    }

    public int UpdateEmployee(int id, EmployeeRequestModel model)
    {
        var employee = new Employee
        {
            Id = id,
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentId = 1
        };
        if (_employeeRepository.Update(employee) > 0)
        {
            Console.WriteLine("Employee Details Updated");
            return _employeeRepository.Update(employee);
        }
        Console.WriteLine($"No Employees found with {id}");
        return 0;
    }

    public int DeleteEmployeeById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee != null && _employeeRepository.DeleteById(id) > 0)
        {
            Console.WriteLine($"Employee with Id : {id} has been deleted");
            return _employeeRepository.DeleteById(id);
        }
        Console.WriteLine("No Employee Found");
        return 0;
    }
    
}