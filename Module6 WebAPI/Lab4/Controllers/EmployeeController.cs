using Microsoft.AspNetCore.Mvc;
using CustomEmployeeApi.Models;
using CustomEmployeeApi.Filters;

namespace CustomEmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter] // ✅ Applies the custom Authorization filter to all requests
    public class EmployeeController : ControllerBase
    {
        // A sample in-memory list of employees
        private readonly List<Employee> _employees;

        // Constructor initializes employee list
        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        // ✅ Creates a hardcoded list of one employee
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Manas Arora",
                    Salary = 70000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1999, 10, 15),
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    }
                }
            };
        }

        // ✅ GET: api/Employee
        // Returns a list of employees
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }

        // ✅ POST: api/Employee
        // Adds an employee (mocked in-memory only)
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return Ok(emp);
        }

        // ✅ GET: api/Employee/fail
        // Throws a sample exception for testing global error filter
        [HttpGet("fail")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ThrowError()
        {
            throw new Exception("Simulated error from GET");
        }
    }
}
