using hrweb.api.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace hrweb.api.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        Department GetSingleDepartment(int id);
    }
}
