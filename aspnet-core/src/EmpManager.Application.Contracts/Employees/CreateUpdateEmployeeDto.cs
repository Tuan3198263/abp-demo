using System;
using System.ComponentModel.DataAnnotations;

namespace EmpManager.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Code { get; set; } = "";

        [Required]
        public string Sex { get; set; } = "";
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Department { get; set; } = "";
        [Required]
        public DateTime BirthDay { get; set; }
    }
}