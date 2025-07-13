using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CustomEmployeeApi.Models;

namespace CustomEmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private readonly List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Manas Arora",
                    Salary = 75000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1999, 10, 15),
                    Department = new Department { Id = 1, Name = "Engineering" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    }
                }
            };
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_employees);
        }
    }
}
