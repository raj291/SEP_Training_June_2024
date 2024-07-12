using EntityFramework.Core.Entities;
using EntityFramework.Core.Interface.Repositories;

namespace EntityFramework.Infrastructure.Repository;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    
}