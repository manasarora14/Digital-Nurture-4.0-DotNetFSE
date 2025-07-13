// File: Models/Employee.cs

namespace CustomEmployeeApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; } // 👈 this is OK if Skill.cs is also in the same namespace
        public DateTime DateOfBirth { get; set; }
    }
}
