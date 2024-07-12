using EntityFramework.Core.Entities;
using EntityFramework.Core.Interface.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repository;

namespace EntityFramework.Infrastructure.Services;

public class DepartmentServices : IDepartmentServices
{
    private DepartmentRepository _departmentRepository = new DepartmentRepository();
    public List<DepartmentResponseModel> GetAllDepartments()
    {
        var departments = _departmentRepository.GetAll();
        var deparmentResponseModels = new List<DepartmentResponseModel>();
        foreach (var department in departments)
        {
            deparmentResponseModels.Add(new DepartmentResponseModel
            {
                DepartmentName = department.DepartmentName,
                Location = department.Location,
                DepartmentId = department.Id,
            });
            
        }

        return deparmentResponseModels;
    }

    public DepartmentResponseModel GetById(int id)
    {
        var department = _departmentRepository.GetById(id);
        if (department != null)
        {
            var departmentResponseModel = new DepartmentResponseModel
            {
                DepartmentName = department.DepartmentName,
                Location = department.Location,
                DepartmentId = department.Id
            };
            return departmentResponseModel;
        }

        return null;
    }

    public int AddDepartment(DepartmentRequestModel model)
    {
        var departmentEntity = new Department
        {
            DepartmentName = model.DepartmentName,
            Location = model.Location
        };
        return _departmentRepository.Insert(departmentEntity);
    }

    public int UpdateDepartment(int id, DepartmentRequestModel model)
    {
        var department = new Department
        {
            Id = id,
            DepartmentName = model.DepartmentName,
            Location = model.Location
        };
        if (_departmentRepository.Update(department) > 0)
        {
            Console.WriteLine("Department has been Updated");
            return _departmentRepository.Update(department);
        }

        return 0;
    }

    public int DeleteDepartmentBy(int id)
    {
        var department = _departmentRepository.DeleteById(id);
        if (department != null && _departmentRepository.DeleteById(id) > 0)
        {
            Console.WriteLine("Department has been deleted");
            return _departmentRepository.DeleteById(id);
        }

        return 0;
    }
}