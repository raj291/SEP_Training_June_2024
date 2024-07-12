using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
namespace EntityFramework.Core.Interface.Services;

public interface IEmployeeServices
{
    List<EmployeeResponseModel> GetAllEmployee();
    EmployeeResponseModel GetById(int id);
    int AddEmployee(EmployeeRequestModel model);
}