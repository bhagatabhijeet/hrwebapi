using hrweb.api.Data;
using hrweb.api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace hrweb.api.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly HrDbContext context;

        public DepartmentRepository(HrDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            var depts = context.Departments.Include("Location").ToList();
            return depts;
        }

        public Department GetSingleDepartment(int id)
        {
            var dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return dept;
        }
    }
}
