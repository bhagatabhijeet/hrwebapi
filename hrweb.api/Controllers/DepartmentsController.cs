using hrweb.api.Data;
using hrweb.api.Models.Domain;
using hrweb.api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hrweb.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            var depts = departmentRepository.GetAllDepartments();
            return Ok(depts);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetSingleDepartment(int id)
        {
            var dept = departmentRepository.GetSingleDepartment(id);
            return Ok(dept);
        }
    }
}
