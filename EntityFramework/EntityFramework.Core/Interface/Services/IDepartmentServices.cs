using EntityFramework.Core.Entities;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;

namespace EntityFramework.Core.Interface.Services;

public interface IDepartmentServices
{
    List<DepartmentResponseModel> GetAllDepartments();
    DepartmentResponseModel GetById(int id);
    int AddDepartment(DepartmentRequestModel model);
    int UpdateDepartment(int id, DepartmentRequestModel model);
    int DeleteDepartmentBy(int id);
}