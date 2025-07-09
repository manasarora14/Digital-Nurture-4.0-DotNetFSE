using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    [ApiController]
    [Route("Emp")] // ✅ Custom route as per requirement
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "John", "Doe", "Alice", "Bob" };
        }
    }
}
